using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCars
{
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса многоуровневой стоянки автобусов.
        /// </summary>
        MultiBusStation busStation;

        /// <summary>
        /// Форма для добавления.
        /// </summary>
        FormBusConfig formBusConfig;

        /// <summary>
        /// Количество уровней стоянки автобусов.
        /// </summary>
        private const int countLevel = 5;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public FormParking()
        {
            InitializeComponent();
            busStation = new MultiBusStation(countLevel, 
                pictureBoxParking.Width, pictureBoxParking.Height);
            // Заполнение listBox.
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень: " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
            //Draw();
        }

        /// <summary>
        /// Отрисовка автовокзала.
        /// </summary>
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                busStation[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        
        /// <summary>
        /// Кнопка "Забрать автобус".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetBus_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlaceNumber.Text != "")
            {
                var bus = busStation[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxPlaceNumber.Text);
                if (bus != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxForBusDraw.Width, pictureBoxForBusDraw.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    bus.SetPosition(5, 5, pictureBoxForBusDraw.Width, pictureBoxForBusDraw.Height);
                    bus.DrawBus(gr);
                    pictureBoxForBusDraw.Image = bmp;
                } else
                {
                    Bitmap bmp = new Bitmap(pictureBoxForBusDraw.Width, pictureBoxForBusDraw.Height);
                    pictureBoxForBusDraw.Image = bmp;
                }
                Draw();
            }
        }

        /// <summary>
        /// Метод обработки выбора элемента в listBoxLevels.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        
        /// <summary>
        /// Обработка нажатия кнопки "Добавить автомобиль".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBus_Click(object sender, EventArgs e)
        {
            formBusConfig = new FormBusConfig();
            formBusConfig.AddEvent(AddBus);
            formBusConfig.Show();
        }

        /// <summary>
        /// Метод добавления машины.
        /// </summary>
        /// <param name="bus"></param>
        private void AddBus(ITransport bus)
        {
            if (bus != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = busStation[listBoxLevels.SelectedIndex] + bus;
                if (place > -1)
                {
                    Draw();
                } else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }
    }
}

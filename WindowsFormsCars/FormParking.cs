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
        /// Кнопка "Поставить автобус".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetBus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var bus = new Bus(0, 0, dialog.Color);
                int place = busStation[listBoxLevels.SelectedIndex] + bus;
                if (place == -1)
                {
                    MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        /// <summary>
        /// Кнопка "Поставить двуярусный автобус".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetDoubleBus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var bus = new DoubleBus(0, 0, dialog.Color, dialogDop.Color, Color.Violet, false);
                    int place = busStation[listBoxLevels.SelectedIndex] + bus;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
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
    }
}

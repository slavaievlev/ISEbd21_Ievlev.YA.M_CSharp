using NLog;
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
    public partial class FormBusStation : Form
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

        private Logger logger;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public FormBusStation()
        {
            InitializeComponent();

            logger = LogManager.GetCurrentClassLogger();

            busStation = new MultiBusStation(countLevel, 
                pictureBoxParking.Width, pictureBoxParking.Height);
            // Заполнение listBox.
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень: " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
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
                try
                {
                    var bus = busStation[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxPlaceNumber.Text);
                    Bitmap bmp = new Bitmap(pictureBoxForBusDraw.Width, pictureBoxForBusDraw.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    bus.SetPosition(5, 5, pictureBoxForBusDraw.Width, pictureBoxForBusDraw.Height);
                    bus.DrawBus(gr);
                    pictureBoxForBusDraw.Image = bmp;

                    logger.Info("Изъят автобус " + bus.ToString() + " с места " + maskedTextBoxPlaceNumber.Text);

                    Draw();
                }
                catch (BusStationNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Bitmap bmp = new Bitmap(pictureBoxForBusDraw.Width, pictureBoxForBusDraw.Height);
                    pictureBoxForBusDraw.Image = bmp;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
                try
                {
                    int place = busStation[listBoxLevels.SelectedIndex] + bus;
                    logger.Info("Добавлен автобус " + bus.ToString() + " на место " + place);

                    Draw();
                }
                catch (BusStationOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    busStation.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (BusStationOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                try
                {
                    busStation.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

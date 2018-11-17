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
    public partial class FormBusConfig : Form
    {
        /// <summary>
        /// Переменная-выбранный автобус.
        /// </summary>
        ITransport bus = null;

        /// <summary>
        /// Событие.
        /// </summary>
        private event busDelegate eventAddBus;

        public FormBusConfig()
        {
            InitializeComponent();
            blackColorPanel.MouseDown += colorPanel_MouseDown;
            blueColorPanel.MouseDown += colorPanel_MouseDown;
            grayColorPanel.MouseDown += colorPanel_MouseDown;
            greenColorPanel.MouseDown += colorPanel_MouseDown;
            orangeColorPanel.MouseDown += colorPanel_MouseDown;
            redColorPanel.MouseDown += colorPanel_MouseDown;
            whiteColorPanel.MouseDown += colorPanel_MouseDown;
            yellowColorPanel.MouseDown += colorPanel_MouseDown;
            buttonClose.Click += (object sended, EventArgs e) => { Close(); };
        }

        /// <summary>
        /// Отрисовать автобус.
        /// </summary>
        private void DrawBus()
        {
            if (bus != null)
            {
                Bitmap bmp = new Bitmap(drawBusPictureBox.Width, drawBusPictureBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bus.SetPosition(5, 5, drawBusPictureBox.Width, drawBusPictureBox.Width);
                bus.DrawBus(gr);
                drawBusPictureBox.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события.
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(busDelegate ev)
        {
            if (eventAddBus == null)
            {
                eventAddBus = new busDelegate(ev);
            } else
            {
                eventAddBus += ev;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void busLabel_MouseDown(object sender, MouseEventArgs e)
        {
            busLabel.DoDragDrop(busLabel.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doublebusLabel_MouseDown(object sender, MouseEventArgs e)
        {
            doublebusLabel.DoDragDrop(doublebusLabel.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelForDrawBusPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            } else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Действия при приеме перетаскиваемой информации.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelForDrawBusPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный автобус":
                    {
                        bus = new Bus(100, 500, Color.White);
                        break;
                    }
                case "Двухярусный автобус":
                    {
                        bus = new DoubleBus(100, 500, Color.White, Color.Black, Color.Yellow, false);
                        break;
                    }
            }
            DrawBus();
        }

        /// <summary>
        /// Передаем информацию при нажатии панели с цветом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorPanel_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorLabel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            } else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Принимаем основной цвет.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorLabel_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                bus.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawBus();
            }
        }

        /// <summary>
        /// Принимаем дополнительный цвет.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dopColorLabel_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                if (bus is DoubleBus) {
                    (bus as DoubleBus).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawBus();
                }
            }
        }

        /// <summary>
        /// Добавление автобуса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddBus?.Invoke(bus);
            Close();
        }
    }
}

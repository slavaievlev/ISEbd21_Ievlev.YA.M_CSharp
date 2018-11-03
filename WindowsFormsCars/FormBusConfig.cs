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

        public FormBusConfig()
        {
            InitializeComponent();
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
    }
}

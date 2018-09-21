using System;
using System.Drawing;
using System.Windows.Forms;
using static WindowsFormsCars.DirectionClass;

namespace WindowsFormsCars
{
    public partial class FormCar : Form
    {
        private ITransport car;

        public FormCar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Отрисовка машины
        /// </summary>
        private void Draw()
        {
            Bitmap bitmap = new Bitmap(pictureBoxCars.Width, pictureBoxCars.Height);
            Graphics gr = Graphics.FromImage(bitmap);
            car.DrawCar(gr);
            pictureBoxCars.Image = bitmap;
        }

        /// <summary>
        /// Кнопки управления
        /// </summary>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    {
                        car.MoveTransport(Direction.Up);
                        break;
                    }

                case "buttonDown":
                    {
                        car.MoveTransport(Direction.Down);
                        break;
                    }

                case "buttonLeft":
                    {
                        car.MoveTransport(Direction.Left);
                        break;
                    }

                case "buttonRight":
                    {
                        car.MoveTransport(Direction.Right);
                        break;
                    }
            }

            Draw();
        }

        /// <summary>
        /// Кнопка "Создать автомобиль"
        /// </summary>
        private void buttonCreateCar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new Bus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Red);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCars.Width, pictureBoxCars.Height);
            Draw();
        }

        /// <summary>
        /// Кнопка "Создать автобус"
        /// </summary>
        private void buttonCreateBus_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new DoubleBus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Red, Color.SkyBlue);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCars.Width, pictureBoxCars.Height);
            Draw();
        }
    }
}

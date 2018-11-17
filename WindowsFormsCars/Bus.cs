using System;
using System.Drawing;
using static WindowsFormsCars.DirectionClass;

namespace WindowsFormsCars
{
    class Bus : Vehicle
    {
        /// <summary>
        /// Ширина автомобиля
        /// </summary>
        protected const int carWidth = 140;

        /// <summary>
        /// Высота автомобиля
        /// </summary>
        protected const int carHeight = 100;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет автомобиля</param>
        public Bus(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Bus(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        /// <summary>
        /// Метод перемещения автомобиля
        /// </summary>
        /// <param name="direction">Направление перемещения</param>
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Left:
                    {
                        if (_startPosX - step > 0)
                        {
                            _startPosX -= step;
                        }
                        break;
                    }

                case Direction.Right:
                    {
                        if (_startPosX + step + carWidth < _pictureWidth)
                        {
                            _startPosX += step;
                        }
                        break;
                    }

                case Direction.Up:
                    {
                        if (_startPosY - step > 0)
                        {
                            _startPosY -= step;
                        }
                        break;
                    }

                case Direction.Down:
                    {
                        if (_startPosY + step + carHeight < _pictureHeight)
                        {
                            _startPosY += step;
                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Метод отрисовки автомобиля
        /// </summary>
        public override void DrawBus(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            // Корпус автобуса
            Brush brush = new SolidBrush(MainColor);
            g.FillRectangle(brush, _startPosX, _startPosY + 30, carWidth, carHeight - 30);

            // Колеса
            Brush brushBlack = new SolidBrush(Color.Black);
            g.FillEllipse(brushBlack, _startPosX + 15, _startPosY + carHeight - 15, 30, 30);
            g.FillEllipse(brushBlack, _startPosX + carWidth - 55, _startPosY + carHeight - 15, 30, 30);

            g.FillEllipse(brush, _startPosX + 20, _startPosY + carHeight - 10, 20, 20);
            g.FillEllipse(brush, _startPosX + carWidth - 50, _startPosY + carHeight - 10, 20, 20);

            //Дверь
            g.DrawRectangle(pen, _startPosX + carWidth - 23, _startPosY + carHeight - 30, 12, 25);

            // Лобовое стекло
            Brush brushBlue = new SolidBrush(Color.SkyBlue);
            g.FillRectangle(brushBlue, _startPosX + carWidth - 25, _startPosY + 38, 26, 30);

            // Стекла
            g.FillRectangle(brushBlue, _startPosX - 1, _startPosY + 45, 30, 20);
            g.FillRectangle(brushBlue, _startPosX + 32, _startPosY + 45, 30, 20);
            g.FillRectangle(brushBlue, _startPosX + 65, _startPosY + 45, 35, 20);

            // Габариты
            Brush brushYellow = new SolidBrush(Color.Yellow);
            g.FillRectangle(brushBlack, _startPosX - 1, _startPosY + 70, 10, 10);
            g.FillRectangle(brushYellow, _startPosX - 1, _startPosY + 82, 10, 10);

            // Фары
            Brush brushWhite = new SolidBrush(Color.White);
            g.FillRectangle(brushWhite, _startPosX + carWidth - 7, _startPosY + 75, 8, 10);
        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}

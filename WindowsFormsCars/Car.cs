using System.Drawing;
using static WindowsFormsCars.DirectionClass;

namespace WindowsFormsCars
{
    class Car : Vehicle
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
        public Car(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
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
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            // Корпус автобуса
            Brush brush = new SolidBrush(MainColor);
            g.FillRectangle(brush, _startPosX, _startPosY, carWidth, carHeight);

            // Колеса
            Brush brushBlack = new SolidBrush(Color.Black);
            g.FillEllipse(brushBlack, _startPosX + 15, _startPosY + carHeight - 15, 30, 30);
            g.FillEllipse(brushBlack, _startPosX + carWidth - 55, _startPosY + carHeight - 15, 30, 30);

            g.FillEllipse(brush, _startPosX + 20, _startPosY + carHeight - 10, 20, 20);
            g.FillEllipse(brush, _startPosX + carWidth - 50, _startPosY + carHeight - 10, 20, 20);
        }
    }
}

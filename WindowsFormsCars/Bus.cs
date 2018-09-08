using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCars
{
    class Bus
    {
        /// <summary>
        /// Координаты автобуса
        /// </summary>
        private float _startPosX;
        private float _startPosY;

        /// <summary>
        /// Границы отрисовки
        /// </summary>
        private int _pictureWidth;
        private int _pictureHeight;

        /// <summary>
        /// Размеры автобуса
        /// </summary>
        private const int carWidth = 140;
        private const int carHeight = 100;

        /// <summary>
        /// Характеристики автобуса
        /// </summary>
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        //public bool FrontSpoiler { private set; get; }
        //public bool SideSpoiler { private set; get; }
        //public bool BackSpoiler { private set; get; }

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        public Bus(int maxSpeed, float weight, Color mainColor, Color dopColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
        }

        public void SetPosition(int x, int y, int width, int heigth)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = heigth;
        }

        /// <summary>
        /// Изменение направления перемещения
        /// </summary>
        /// <param name="direction"></param>
        public void MoveTransport(Direction direction)
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

        public void DrawCar(Graphics g)
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

            //Дверь
            g.DrawRectangle(pen, _startPosX + carWidth - 23, _startPosY + carHeight - 30, 12, 25);

            // Лобовое стекло
            Brush brushBlue = new SolidBrush(Color.SkyBlue);
            g.FillRectangle(brushBlue, _startPosX + carWidth - 25, _startPosY + 18, 26, 50);

            // Стекла
            g.FillRectangle(brushBlue, _startPosX - 1, _startPosY + 18, 30, 20);
            g.FillRectangle(brushBlue, _startPosX + 32, _startPosY + 18, 30, 20);
            g.FillRectangle(brushBlue, _startPosX + 65, _startPosY + 18, 45, 20);

            g.FillRectangle(brushBlue, _startPosX - 1, _startPosY + 45, 30, 20);
            g.FillRectangle(brushBlue, _startPosX + 32, _startPosY + 45, 30, 20);
            g.FillRectangle(brushBlue, _startPosX + 65, _startPosY + 45, 35, 20);

            // Сигнальные фонари сзади (как они называются?)
            Brush brushYellow = new SolidBrush(Color.Yellow);
            g.FillRectangle(brushBlack, _startPosX - 1, _startPosY + 70, 10, 10);
            g.FillRectangle(brushYellow, _startPosX - 1, _startPosY + 82, 10, 10);

            // Фары
            Brush brushWhite = new SolidBrush(Color.White);
            g.FillRectangle(brushWhite, _startPosX + carWidth - 7, _startPosY + 75, 8, 10);
        }


    }
}

using System;
using System.Drawing;

namespace WindowsFormsCars
{
    class DoubleBus : Bus
    {
        // Дополнительный цвет
        public Color DopColor { private set; get; }

        // Цвет фар
        public Color HeadlampsColor { private set; get; }

        // Наличие второго заднего колеса
        public bool IsExtraWheel { private set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        public DoubleBus(int maxSpeed, float weight, Color mainColor, Color dopColor,
            Color headlampsColor, bool isExtraWheel) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            HeadlampsColor = headlampsColor;
            IsExtraWheel = isExtraWheel;
        }

        public DoubleBus(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                HeadlampsColor = Color.FromName(strs[4]);
                IsExtraWheel = Convert.ToBoolean(strs[5]);
            }
        }

        /// <summary>
        /// Метод отрисовки автобуса
        /// </summary>
        public override void DrawBus(Graphics g)
        {
            base.DrawBus(g);

            Pen pen = new Pen(Color.Black);

            // Корпус автобуса
            Brush brush = new SolidBrush(MainColor);
            g.FillRectangle(brush, _startPosX, _startPosY, carWidth, carHeight - 70);

            // Лобовое стекло
            Brush brushBlue = new SolidBrush(Color.SkyBlue);
            g.FillRectangle(brushBlue, _startPosX + carWidth - 25, _startPosY + 15, 26, 23);

            // Стекла
            Brush brushDop = new SolidBrush(DopColor);
            g.FillRectangle(brushDop, _startPosX - 1, _startPosY + 18, 30, 20);
            g.FillRectangle(brushDop, _startPosX + 32, _startPosY + 18, 30, 20);
            g.FillRectangle(brushDop, _startPosX + 65, _startPosY + 18, 45, 20);

            // Фары (наложение новых фар на старые)
            Brush brushWhite = new SolidBrush(HeadlampsColor);
            g.FillRectangle(brushWhite, _startPosX + carWidth - 7, _startPosY + 75, 8, 10);

            if (IsExtraWheel)
            {
                // Дополнительное колесо
                Brush brushBlack = new SolidBrush(Color.Black);
                g.FillEllipse(brushBlack, _startPosX + 50, _startPosY + carHeight - 15, 30, 30);
            }
        }

        /// <summary>
        /// Смена дополнительного цвета автобуса.
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + HeadlampsColor.Name + ";" + IsExtraWheel;
        }
    }
}

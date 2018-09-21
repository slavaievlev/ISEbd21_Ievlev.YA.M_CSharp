using System.Drawing;

namespace WindowsFormsCars
{
    class Bus : Car
    {
        public Color DopColor { private set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        public Bus(int maxSpeed, float weight, Color mainColor, Color dopColor) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
        }

        /// <summary>
        /// Метод отрисовки автобуса
        /// </summary>
        public override void DrawCar(Graphics g)
        {
            base.DrawCar(g);

            Pen pen = new Pen(Color.Black);

            //Дверь
            g.DrawRectangle(pen, _startPosX + carWidth - 23, _startPosY + carHeight - 30, 12, 25);

            // Лобовое стекло
            Brush brushBlue = new SolidBrush(DopColor);
            g.FillRectangle(brushBlue, _startPosX + carWidth - 25, _startPosY + 18, 26, 50);

            // Стекла
            g.FillRectangle(brushBlue, _startPosX - 1, _startPosY + 18, 30, 20);
            g.FillRectangle(brushBlue, _startPosX + 32, _startPosY + 18, 30, 20);
            g.FillRectangle(brushBlue, _startPosX + 65, _startPosY + 18, 45, 20);

            g.FillRectangle(brushBlue, _startPosX - 1, _startPosY + 45, 30, 20);
            g.FillRectangle(brushBlue, _startPosX + 32, _startPosY + 45, 30, 20);
            g.FillRectangle(brushBlue, _startPosX + 65, _startPosY + 45, 35, 20);

            // Габариты
            Brush brushBlack = new SolidBrush(Color.Black);
            Brush brushYellow = new SolidBrush(Color.Yellow);
            g.FillRectangle(brushBlack, _startPosX - 1, _startPosY + 70, 10, 10);
            g.FillRectangle(brushYellow, _startPosX - 1, _startPosY + 82, 10, 10);

            // Фары
            Brush brushWhite = new SolidBrush(Color.White);
            g.FillRectangle(brushWhite, _startPosX + carWidth - 7, _startPosY + 75, 8, 10);
        }
    }
}

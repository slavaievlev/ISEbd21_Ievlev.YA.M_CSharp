using System.Drawing;

namespace WindowsFormsCars
{
    class DoubleBus : Bus
    {
        public Color DopColor { private set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        public DoubleBus(int maxSpeed, float weight, Color mainColor, Color dopColor) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
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
        }
    }
}

using System.Drawing;
using static WindowsFormsCars.DirectionClass;

namespace WindowsFormsCars
{
    public abstract class Vehicle : ITransport
    {
        /// <summary>
        /// Координата X
        /// </summary>
        protected float _startPosX;

        /// <summary>
        /// Координата Y
        /// </summary>
        protected float _startPosY;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        protected int _pictureHeight;

        /// <summary>
        /// Максимальная скорость транспортного средства
        /// </summary>
        public int MaxSpeed {protected set; get; }

        /// <summary>
        /// Вес транспортного средства
        /// </summary>
        public float Weight { protected set; get; }

        /// <summary>
        /// Основной цвет транспортного средства
        /// </summary>
        public Color MainColor { protected set; get; }

        /// <summary>
        /// Определение места отрисовки транспортного средства
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина окна отрисовки</param>
        /// <param name="height">Высота окна отрисовки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        /// <summary>
        /// Смена основного цвета автобуса.
        /// </summary>
        /// <param name="color"></param>
        public void SetMainColor(Color color)
        {
            MainColor = color;
        }

        /// <summary>
        /// Метод отрисовки транспортного средства
        /// </summary>
        public abstract void DrawBus(Graphics g);

        /// <summary>
        /// Метод перемещения транспортного средства
        /// </summary>
        /// <param name="direction">Направление перемещения</param>
        public abstract void MoveTransport(Direction direction);
    }
}

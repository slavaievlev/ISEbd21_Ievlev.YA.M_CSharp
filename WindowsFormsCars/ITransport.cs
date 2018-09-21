using System.Drawing;

namespace WindowsFormsCars
{
    interface ITransport
    {
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        void SetPosition(int x, int y, int width, int height);

        /// <summary>
        /// Изменение направления движения
        /// </summary>
        /// <param name="direction">Направление</param>
        void MoveTransport(Bus.Direction direction);

        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        void DrawCar(Graphics g);
    }
}

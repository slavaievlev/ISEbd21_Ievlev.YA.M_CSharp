using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    class BusStation <T> where T : class, ITransport
    {
        /// <summary>
        /// Словарь объектов-автобусов.
        /// </summary>
        private Dictionary<int, T> _places;

        /// <summary>
        /// Максимальное количество мест на парковке.
        /// </summary>
        private int _maxCount;

        /// <summary>
        /// Размер одного места парковки по ширине.
        /// </summary>
        private int _placeSizeWidth = 220;

        /// <summary>
        /// Размер одного места парковки по высоте.
        /// </summary>
        private int _placeSizeHeight = 130;

        /// <summary>
        /// Размер парковки по ширине.
        /// </summary>
        private int PictureWidth { set; get; }

        /// <summary>
        /// Размер парковки по высоте.
        /// </summary>
        private int PictureHeight { set; get; }

        /// <summary>
        /// Конструктор парковки.
        /// </summary>
        /// <param name="sizes">Вместимость автовокзала.</param>
        /// <param name="pictureWidth">Размер автовокзала по ширине.</param>
        /// <param name="pictureHeight">Размер автовокзала по высоте.</param>
        public BusStation(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }

        /// <summary>
        /// Оператор "+": Поставить автобус.
        /// </summary>
        /// <param name="p">Объект "автовокзал".</param>
        /// <param name="vehicle">Объект интерфейса ITransport.</param>
        /// <returns></returns>
        public static int operator +(BusStation<T> p, T vehicle)
        {
            if (p._places.Count == p._maxCount)
            {
                return -1;
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, vehicle);
                    p._places[i].SetPosition(5 + i / 5 * p._placeSizeWidth + 5,
                        i % 5 * p._placeSizeHeight + 10,
                        p.PictureWidth, p.PictureHeight);

                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Оператор "-": забрать автобус.
        /// </summary>
        /// <param name="p">Объект "Автовокзал".</param>
        /// <param name="index">Номер места.</param>
        /// <returns></returns>
        public static T operator -(BusStation<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T vahicle = p._places[index];
                p._places.Remove(index);
                return vahicle;
            }
            return null;
        }

        /// <summary>
        /// Проверить по номеру места, свободно ли оно.
        /// </summary>
        /// <param name="index">Номер места.</param>
        /// <returns></returns>
        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }

        /// <summary>
        /// Отрисовка автовокзала.
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].DrawBus(g);
            }
        }

        /// <summary>
        /// Отрисовка разметки.
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, _placeSizeWidth * 4, _placeSizeHeight * 5);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    g.DrawLine(pen, j * _placeSizeWidth, i * _placeSizeHeight,
                        j * _placeSizeWidth + _placeSizeWidth / 5 * 3,
                        i * _placeSizeHeight);

                    g.DrawLine(pen, j * _placeSizeWidth, i * _placeSizeHeight,
                        j * _placeSizeWidth,
                        i * _placeSizeHeight + _placeSizeHeight);
                }
            }
        }
    }
}

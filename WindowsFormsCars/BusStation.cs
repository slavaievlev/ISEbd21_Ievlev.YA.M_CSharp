using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    class BusStation <T> : IEnumerator<T>, IEnumerable<T>, IComparable<BusStation<T>> where T : class, ITransport
    {
        /// <summary>
        /// Словарь объектов-автобусов.
        /// </summary>
        Dictionary<int, T> _places;

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

        private int _currentIndex;

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
            _currentIndex = -1;
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
                throw new BusStationOverflowException();
            }
            if (p._places.ContainsValue(vehicle))
            {
                throw new BusStationAlreadyHaveException();
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
            throw new BusStationNotFoundException(index);
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

        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                throw new BusStationNotFoundException(ind);
            }

            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5,
                        ind % 5 * _placeSizeHeight + 10,
                        PictureWidth, PictureHeight);
                } else
                {
                    throw new BusStationOccupiedPlaceException(ind);
                }
            }
        }

        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        
        public void Dispose()
        {
            _places.Clear();
        }

        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(BusStation<T> other)
        {
            if (_places.Count > other._places.Count)
            {
                return -1;
            }
            else if (_places.Count < other._places.Count)
            {
                return 1;
            }
            else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; i++)
                {
                    if (_places[thisKeys[i]] is Bus && other._places[thisKeys[i]] is DoubleBus)
                    {
                        return 1;
                    }

                    if (_places[thisKeys[i]] is DoubleBus && other._places[thisKeys[i]] is Bus)
                    {
                        return -1;
                    }

                    if (_places[thisKeys[i]] is Bus && other._places[thisKeys[i]] is Bus)
                    {
                        return (_places[thisKeys[i]] is Bus).CompareTo(other._places[thisKeys[i]] is Bus); ;
                    }

                    if (_places[thisKeys[i]] is DoubleBus && other._places[thisKeys[i]] is DoubleBus)
                    {
                        return (_places[thisKeys[i]] is DoubleBus).CompareTo(other._places[thisKeys[i]] is DoubleBus); ;
                    }
                }
            }
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    /// <summary>
    /// Класс многоуровневой стоянки автобусов.
    /// </summary>
    class MultiBusStation
    {
        /// <summary>
        /// Список с уровнями парковки.
        /// </summary>
        List<BusStation<ITransport>> busStationsStages;

        /// <summary>
        /// Сколько мест на каждом уровне.
        /// </summary>
        private const int countPlaces = 20;

        public MultiBusStation(int countStages, int pictureWidth, int pictureHeight)
        {
            busStationsStages = new List<BusStation<ITransport>>();
            for (int i = 0; i < countStages; i++)
            {
                busStationsStages.Add(new BusStation<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        /// <summary>
        /// Индексатор.
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public BusStation<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < busStationsStages.Count)
                {
                    return busStationsStages[ind];
                }
                return null;
            }
        }
    }
}

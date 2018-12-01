using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    class BusStationNotFoundException : Exception
    {
        public BusStationNotFoundException(int i) : base("Не найден автобус по месту " + i) { }
    }
}

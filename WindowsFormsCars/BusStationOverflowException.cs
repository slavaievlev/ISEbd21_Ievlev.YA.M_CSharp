using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    class BusStationOverflowException : Exception
    {
        public BusStationOverflowException() : base("На автобусной стоянке нет свободных мест") { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    class BusStationAlreadyHaveException : Exception
    {
        public BusStationAlreadyHaveException() : base("На стоянке автобусов уже есть такой автобус")
        { }
    }
}

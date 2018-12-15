using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDumpTruck
{
    /// <summary>
    /// Класс-ошибка "Если место, на которое хотим поставить грузовик уже занято"
    /// </summary>
    public class ParkingOccupiedPlaceException : Exception
    {
        public ParkingOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит грузовик")
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDumpTruck
{
    /// <summary>
    /// Класс-ошибка "Если не найден грузовик по определенному месту"
    /// </summary>
    public class ParkingNotFoundException : Exception
    {
        public ParkingNotFoundException(int i) : base("Не найден грузовик по месту " +i)
        { }
    }
}

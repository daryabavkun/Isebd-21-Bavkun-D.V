using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDumpTruck
{
    public class DumpTruck : Truck, IComparable<DumpTruck>, IEquatable<DumpTruck>
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// кузов
        /// </summary>
        public bool Body { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес грузовика</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="body"> кузов </param>
        public DumpTruck(int maxSpeed, float weight, Color mainColor, Color dopColor, bool body) :
            base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Body = body;
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public DumpTruck(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 5)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Body = Convert.ToBoolean(strs[4]);
            }
        }
        public override void DrawTruck(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            //кузов
            Brush br = new SolidBrush(DopColor);
            if (Body)
            {
                g.FillRectangle(br, _startPosX + 10, _startPosY + 20, 120, 50);
            }
            base.DrawTruck(g);
        }
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Body;
        }
        /// <summary>
        /// Метод интерфейса IComparable для класса DumpTruck
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(DumpTruck other)
        {
            var res = (this is Truck).CompareTo(other is Truck);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Body != other.Body)
            {
                return Body.CompareTo(other.Body);
            }
            return 0;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса DumpTruck
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(DumpTruck other)
        {
            var res = (this as Truck).Equals(other as Truck);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Body != other.Body)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            DumpTruck truckObj = obj as DumpTruck;
            if (truckObj == null)
            {
                return false;
            }
            else
            {
                return Equals(truckObj);
            }
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
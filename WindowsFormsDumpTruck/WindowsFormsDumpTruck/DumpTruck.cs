using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDumpTruck
{
    public class DumpTruck : Truck
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
    }
}

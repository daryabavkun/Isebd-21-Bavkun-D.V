using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDumpTruck
{
    public partial class FormTruck : Form
    {
        private ITransport dumptruck;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormTruck()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод отрисовки грузовика
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDumpTruck.Width, pictureBoxDumpTruck.Height);
            Graphics gr = Graphics.FromImage(bmp);
            dumptruck.DrawTruck(gr);
            pictureBoxDumpTruck.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать грузовик"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonCreateTruck_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            dumptruck = new Truck(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            dumptruck.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxDumpTruck.Width, pictureBoxDumpTruck.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать грузовик-самосвал"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateDumpTruck_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            dumptruck = new DumpTruck(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true);
            dumptruck.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxDumpTruck.Width, pictureBoxDumpTruck.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    dumptruck.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    dumptruck.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    dumptruck.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    dumptruck.MoveTransport(Direction.Right);
                    break;
            }
            Draw();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1.Pr6
{
    internal class Toy : Produkt, IDeliver
    {
        int number;
        public Toy(string name, double price, int Number) : base(name, price) { this.number = Number; }

        public Toy() : base("Car",0)
        {
            number = 30;
        }
        public string Deliver()
        {
            return "Доставляємо іграшки";
        }

        public void Toy_Require_Event()
        {
            MessageBox.Show(Deliver());
        }


    }
}

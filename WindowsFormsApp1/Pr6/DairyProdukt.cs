using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Pr6
{
    internal class DairyProdukt : Produkt, IDeliver, ICook
    {
        double weith;
        public DairyProdukt(string name, double price, double Weith) : base(name, price) { this.weith = Weith; } 
        public DairyProdukt(double Weith) : base("Cees", 0)
        {
            this.weith = Weith;
        }


        public void Cooking()
        {
            this.weith += 6;
        }

        public string Deliver()
        {
            return "Веземо молочну продукцію";
        }

        public string Cook()
        {
            return "Готуємо молочку";
        }

        public void Diary_Require_Event()
        {
            
            while (weith < 40) 
            {
                Cooking();
                MessageBox.Show(Cook());
            }

            MessageBox.Show(Deliver());
        }
    }
}

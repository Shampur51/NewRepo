using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Pr6
{
    abstract class Produkt : Tovar
    {
        public double Price { get; set; }

        protected Produkt(string name, double price) : base(name)
        {
            Price = price;
        }
    }
}

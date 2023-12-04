using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Pr6
{

    delegate void MyEvent();

    internal class Order
    {
        public event MyEvent activate;

        public void order(double dairyProd)
        {
            if (activate != null && dairyProd <= 20)
            { 
                activate();
            }
        }
    }
}

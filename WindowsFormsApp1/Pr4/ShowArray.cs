using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Pr4
{
    internal class ShowArray
    {
        public string writeArray(double[] array)
        {
            string s = "";

            foreach (int i in array) 
            {
                s += i.ToString() + " ";
            }

            return s;
        }
    }
}

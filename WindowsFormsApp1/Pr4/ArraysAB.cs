using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Pr4
{
    public class ArraysAB
    {
        public double[] a;
        public double[] b;
        int lenth = 10;

        public int Lentgh { get { return lenth; } }

        public ArraysAB ()
        {
            a = new double[lenth];
            b = new double[lenth];
        }
        
        public bool calculate()
        {
            int check = 10, checkRes = 0;

            for (int i = 0; i < lenth; i++)
            {
                if (Math.Pow((a[i] - 1), 2) + Math.Pow((b[i] - 1), 2) == 4)
                    checkRes++;
            }

            if (checkRes == check)
                return true;

            else
            return false;
        }


    }
}

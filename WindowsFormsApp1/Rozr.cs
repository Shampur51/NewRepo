using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Rozr
    {

        public double[,] xy = new double[1000, 2];

        public double n = 0;

        private double f1(double x)
        {
            return Math.Exp(-2 * x) + Math.Pow(2 * Math.Pow(x, 4) + Math.Pow(x, 2) - 1.0, 1.0/7.0);
        }

        private double f2(double x)
        {
            return (Math.Pow(x, 3) + 2*x*x - 4*x) / (Math.Pow(x, 5) * (1 / Math.Tan(x*x*x * 2)));
        }

        private double f3(double x)
        {
            return (Math.Pow(Math.Cos(Math.Pow(x+2, 3)), 2)) / (2 * Math.Sqrt(Math.Pow(x, 3)) * Math.Sin(Math.Pow(x, 3)));
        }

        public void tab (double xn = 2.9, double xk = 17.48, double h = 0.1, double a = 0.3)
        {
            double x = xn, y;
            int i = 0;

            while (x<=xk)
            {

                if(x < 0)
                {
                    y= f1(x);
                }
                else
                {

                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                        y = f3(x);
                }

                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Pr3
{
    public class CalcABC
    {
        int a, b, c;

        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }
        public int C { get { return c; } set { c = value; } }

        public CalcABC(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double rez()
        {
            if ( a% 2 == 0)
                return Math.Pow(a+b+c, 3);

            else if (b % 2 == 0)
                return Math.Pow(a + b + c, 3);

            else if (c % 2 == 0)
                return Math.Pow(a + b + c, 3);

            else
                return Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3);
        }
    }
}

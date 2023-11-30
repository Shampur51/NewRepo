using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Pr3
{
    public class CalcAB
    {
        int a, b;

        public int A {  get { return a; } set {  a = value; } }
        public int B { get { return b; } set { b = value; } }

        public CalcAB (int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Sum()
        {
            int sum = 0;

            if (a > b)
                throw new ArgumentOutOfRangeException("А більше за В");

            if (a == b)
                return 0;

            else
            {
                for (int i = a; i <= b; i++)
                    if (i % 2 == 0)
                        sum += i;

                return sum;
            }
        }
    }
}

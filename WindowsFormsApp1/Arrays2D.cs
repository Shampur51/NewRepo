using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp1
{
    internal class Arrays2D
    {
        public bool error = false;
        private int[,] a;
        int x_l = 5;
        int y_l = 5;

        public int X_l
        {
            get { return x_l; }
            set { x_l = value; }
        }

        public int Y_l
        {
            get { return y_l; }
            set { y_l = value; }
        }

        public int this [int i, int j]
        {
            get
            {
                if (i >= 0 && i < x_l && j >= 0 && j < y_l && i <= 5 && j <= 5)
                    return a[i, j];
                else 
                {
                    error = true;
                    return 0;
                }
            }

            set
            {
                if (i >= 0 && i < x_l && j >= 0 && j < y_l)
                    a[i, j] = value;
                else 
                {
                    error = true;
                }

            }
        }

        void GenRand(int n, int m)
        {
            Random rand = new Random();

            for (int i = 0; i < n; i++)
                for(int j = 0; j < m; j++)
                a[i, j] = rand.Next(-500, 1000);      
        }

        public Arrays2D()
        {
            a = new int[x_l, y_l];
            GenRand(x_l, y_l);
        }

        public Arrays2D(int a_x, int a_y)
        {
            X_l = a_x;
            Y_l = a_y;
            a = new int[a_x, a_y];
            GenRand(a_x, a_y);
        }

        public (int, int) Nayb_Vidn_LivDiag
        {
            get
            {
                int El, Pol = 0;
                El = a[0, 0];

                for (int i = 0; i < X_l; i++)
                    for (int j = 0; j < Y_l; j++)
                    {
                        if (a[i, j] > El)
                        {
                            El = a[i, j];
                            Pol = i - j;
                        }  
                    } 
                
                return (El, Pol);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp1
{
    internal class Arrays
    {
        public bool error = false;
        int [] a;
        int l = 12;

        public int L
        {
            get { return l; }
            set { l = value; }
        }

        public Arrays()
        {
            a = new int[l];
            GenRand(l);
        }

        void GenRand (int n)
        {
            Random rand = new Random();
            int  maxT = 30, minT = maxT-8;

            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(minT, maxT);

                maxT = a[i];
                minT = maxT - 6;

                maxT -= rand.Next(0, 4);
            }
        }

        public Arrays(int size)
        {
               l = size;

               a = new int[l];
               GenRand(l);
          
        }

        public int this[int i]
        {
            get
            {
                if(i >= 0 &&  i < l)
                    return a[i];
                else
                {
                    error = true;
                    return 0;
                }
            }
        }

        public int WhatTime()
        {
            for (int i = 0; i < l; i++)
            {
                if (a[i] < 0)
                return i+8;
            }

            return 0;
        }

    }
}

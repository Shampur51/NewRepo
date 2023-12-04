using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Pr6
{
    abstract class Tovar
    {
        public string Name { get; set; }

        protected Tovar(string name)
        {
            Name = name;
        }
    }
}

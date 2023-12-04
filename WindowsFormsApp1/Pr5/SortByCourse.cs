using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Pr5
{
    internal class SortByCourse: IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Course < y.Course) return -1;
            if (x.Course > y.Course) return 1;
                return 0;
        }
    }
}

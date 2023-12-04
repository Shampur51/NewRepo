using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Pr4
{
    internal class FileWrite:IWrite
    {
        public void write(string patch1, string patch2, ArraysAB a)
        {
            using (StreamWriter sa = new StreamWriter(patch1, false,
                System.Text.Encoding.Default))
            {
                foreach (var item in a.a)
                {
                    sa.WriteLine(item.ToString());
                }

                sa.Close();
            }

            using (StreamWriter sb = new StreamWriter(patch2, false,
                System.Text.Encoding.Default))
            {
                foreach (var item in a.b)
                {
                    sb.WriteLine(item.ToString());
                }

                sb.Close();
            }
        }
    }
}

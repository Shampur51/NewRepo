using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Pr4
{
    internal class FileRead:IRead
    {
        public void read(string patch1, string patch2, ArraysAB a)
        {
            using (StreamReader sa = new StreamReader(patch1, 
                System.Text.Encoding.Default))

            {
                string line = " ";

                try
                {
                    int i = 0;
                    while ((line = sa.ReadLine()) != null)
                    {
                        a.a[i] = Convert.ToDouble(line);
                        i++;
                    }
                    sa.Close();
                }

                catch {throw new AccessViolationException("Error in file"); }
            }

            using (StreamReader sb = new StreamReader(patch2,
                System.Text.Encoding.Default))

            {
                string line = " ";

                try
                {
                    int i = 0;
                    while ((line = sb.ReadLine()) != null)
                    {
                        a.b[i] = Convert.ToDouble(line);
                        i++;
                    }
                    sb.Close();
                }

                catch { throw new AccessViolationException("Error in file"); }
                
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1.Pr5
{
    internal class Students
    {
        public List<Student> students= new List<Student>();

        XmlSerializer serializer = new XmlSerializer(typeof (List<Student>));
        
        public void add(Student student)
        {
            students.Add(student);
        }

        public void remove(int i)
        {
            students.RemoveAt(i);
        }

        public void sort()
        {
            SortByCourse sa = new SortByCourse();
            students.Sort(sa);
        }

        public void writeFile (string filename)
        {
            FileStream fstream = new FileStream(filename, FileMode.Create,
                FileAccess.Write, FileShare.None);

            serializer.Serialize(fstream, students);

            fstream.Close();
        }

        public void readFile(string filename)
        {
            FileStream fstream = new FileStream(filename, FileMode.Open,
                FileAccess.Read, FileShare.None);

            students = serializer.Deserialize(fstream) as List<Student>;

            fstream.Close();
        }



    }
}

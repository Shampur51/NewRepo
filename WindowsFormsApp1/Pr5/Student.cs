using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Pr5;

namespace WindowsFormsApp1.Pr5
{
    public class Student: IComparable
    {
        string surname;
        string faculty;
        int course;
        string group;
        int [] mark;
        int compareIndex;

        public Student(string surname, string faculty,int course, string group, int[] mark)
        {
            Surname = surname;
            Faculty = faculty; 
            Course = course;
            Group = group;
            this.mark = mark;
            compareIndex = 0;
        }

        public Student()
        {
            var r = new Random();
            int[] a = { r.Next(2, 5), r.Next(2, 5), r.Next(2, 5), r.Next(2, 5), r.Next(2, 5) };

            this.Surname = "Гуппі";
            this.Faculty = "ФІТ";
            this.Course = r.Next(1, 4);
            this.group = "ІР-21";
            mark = a;
            compareIndex = 0;
        }

        public string Surname { get { return this.surname; } set { this.surname = value; } }
        public string Faculty { get { return this.faculty; } set { this.faculty = value; } }
        public int Course 
        { get { return this.course; } 
            set 
            {
                if (value > 0 && value < 5)
                    this.course = value;
                else
                    throw new Exception("Course out of range");
            } 
        }
        public string Group { get { return this.group; } set { this.group = value; } }
        public int[] Mark
        {
            get { return this.mark; }
            set 
            {
                    this.mark = value; 
            }
        }
        public int CompareIndex
        {
            get { return this.compareIndex; }
            set
            {
                    this.compareIndex = value;
            }
        }

        public int CompareTo(object obj)
        {
            Student p = obj as Student;
            return mark[compareIndex].CompareTo(p.Mark[CompareIndex]);
        }

    }
}


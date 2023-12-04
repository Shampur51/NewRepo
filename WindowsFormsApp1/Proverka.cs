using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Pr5;

namespace WindowsFormsApp1
{
    public partial class Proverka : Form
    {

        Students students = new Students();
        string path = "data.xml";

        public void show(DataGridView dg)
        {
            dg.Rows.Clear();
            foreach (Student s in students.students)
            {
                dg.Rows.Add(s.Surname, s.Group, s.Course);
            }

        }
        public Proverka()
        {
            InitializeComponent();
        }

        private void butt_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

  

        /* private void Interf_Activated(object sender, EventArgs e)
         {
             Size = new Size(800, 550);
             dataGridView3.Rows.Clear();
         }*/

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }


        private void button4_Click(object sender, EventArgs e)
        {
          
        }

  
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void butt_Click_1(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                int[] a = { Convert.ToInt32(mark_1.Text), Convert.ToInt32(mark_2.Text), Convert.ToInt32(mark_3.Text), Convert.ToInt32(mark_4.Text), Convert.ToInt32(mark_5.Text) };

                for (int i = 0; i < 5; i++)
                {
                    if (a[i] <= 1 || a[i] > 5)
                    { throw new Exception("Не неможливі оцінки"); }
                }

                if (Convert.ToInt32(cour.Text) < 1 || Convert.ToInt32(cour.Text) > 4)
                    throw new Exception("Не корректний курс");

                var student = new Student(
                    surn.Text,
                    fuck.Text,
                    Convert.ToInt32(cour.Text),
                    grou.Text, a);


                students.add(student);
                dataGridView1.Rows.Add(
                    students.students[students.students.Count - 1].Surname,
                    students.students[students.students.Count - 1].Group,
                    students.students[students.students.Count - 1].Course);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch { MessageBox.Show("Помилкові дані"); }
        }


        //фільтрація за оцінкою 2
        private void button6_Click_1(object sender, EventArgs e)
        {

            students.sort();
            dataGridView3.Rows.Clear();
            bool x = false;

              foreach (Student s in students.students)
            {
                x = false;
                for (int i = 0; i < 5; i++)
                {
                    s.CompareIndex = i;
                    if (s.Mark[i] == 2)
                        x = true;
                }

                if (x == true)
                {
                    dataGridView3.Rows.Add(s.Surname, s.Group, s.Course);
                }


                s.CompareIndex = 0;

            }
           

        }

        //читaння з файлу
        private void button1_Click_1(object sender, EventArgs e)
        {
            students.readFile(path);
            show(dataGridView1);
        }



        //запис у файл
        private void button5_Click_1(object sender, EventArgs e)
        {
            students.writeFile(path);
            MessageBox.Show("Дані записано");
        }



        //видалення
        private void button3_Click_1(object sender, EventArgs e)
        {
            var i = dataGridView1.CurrentRow.Index;
            students.remove(i);
            show(dataGridView1);
        }


        //сортування
        private void button4_Click_1(object sender, EventArgs e)
        {
            students.sort();
            show(dataGridView2);
        }
    }
}

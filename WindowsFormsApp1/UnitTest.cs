using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Pr3;

namespace WindowsFormsApp1
{
    public partial class UnitTest : Form
    {
        public UnitTest()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0, c = 0;

                a = Convert.ToInt32(textBox3.Text);
                b = Convert.ToInt32(textBox4.Text);
                c = Convert.ToInt32(textBox5.Text);

                var calc = new CalcABC(a, b, c);

                label10.Text = calc.rez().ToString();
            }

            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0;

                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);

                var calc = new CalcAB(a, b);

                label7.Text = calc.Sum().ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

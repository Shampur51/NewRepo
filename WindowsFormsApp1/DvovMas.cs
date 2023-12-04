using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DvovMas : Form
    {
        public DvovMas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void DvovMas_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0, m = 0;

                n = Convert.ToInt32(Xget.Text);
                m = Convert.ToInt32(Yget.Text);

                if (n > 5 || m > 5)
                    throw new Exception("Масив більший за 5/5");

                Arrays2D b = new Arrays2D(n, m);
                DataGridViewTextBoxColumn dvage;

                for(int i =0; i<m; i++)
                {
                    dvage = new DataGridViewTextBoxColumn();
                    dvage.Width = 40;
                    dataGridView1.Columns.Add(dvage);
                }

                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = b.X_l;
                dataGridView1.ColumnCount = b.Y_l;

                for (int i = 0; i < b.X_l; i++)
                    for (int j = 0; j < b.Y_l; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = b[i, j].ToString();
                    }

                var r = b.Nayb_Vidn_LivDiag;
                label5.Text = r.Item1.ToString();
                label6.Text = r.Item2.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

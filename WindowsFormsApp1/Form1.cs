﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Rozr tabul = new Rozr();

                double xn, xk, h, a;

                xn = Convert.ToDouble(this.textBox1.Text);
                xk = Convert.ToDouble(this.textBox2.Text);
                h = Convert.ToDouble(this.textBox3.Text);
                a = Convert.ToDouble(this.textBox4.Text);

                dataGridView1.Rows.Clear();
                chart1.Series[0].Points.Clear();

                tabul.tab(xn, xk, h, a);

                for (int i = 0; i < tabul.n; i++)
                {
                    dataGridView1.Rows.Add(Math.Round(tabul.xy[i, 0], 2).ToString(),
                        Math.Round(tabul.xy[i, 1], 3).ToString());

                    chart1.Series[0].Points.AddXY(tabul.xy[i, 0], tabul.xy[i, 1]);

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void одномірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdnMas f = new OdnMas();
            f.Show();
            this.Hide();
        }

        private void двовимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DvovMas f = new DvovMas();
            f.Show();
            this.Hide();
        }

        private void unitTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitTest f = new UnitTest();
            f.Show();
            this.Hide();
        }

        private void роботаЗФайламиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File f = new File();
            f.Show();
            this.Hide();
        }

        private void стандартніІнтерфейсиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proverka f = new Proverka();
            f.Show();
            this.Hide();
        }

        private void подіїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Podiyi f = new Podiyi();
            f.Show();
            this.Hide();
        }

        private void масивиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

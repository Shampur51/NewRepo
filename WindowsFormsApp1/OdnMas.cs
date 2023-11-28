using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class OdnMas : Form
    {
        public OdnMas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                
                
                if (n > 13)
                     throw new Exception("Завеликий масив");

                Arrays a = new Arrays(n);

             
                for (int i = 0 ; i<a.L; i++)
                {
                    dataGridView1.Rows.Add(a[i].ToString());
                }

                var T = a.WhatTime();

                if (T == 0)
                    TimeT.Text = "Сьогодні було тепло";
                else
                    TimeT.Text = T.ToString();
            }

            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

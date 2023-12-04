using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Pr6;

namespace WindowsFormsApp1
{
    public partial class Podiyi : Form
    {
        public Podiyi()
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
            double w = Convert.ToDouble(textBox1.Text);

            Order ord = new Order();
            Toy toy = new Toy();
            DairyProdukt dair = new DairyProdukt(w);

            ord.activate += new MyEvent(dair.Diary_Require_Event);
            ord.activate += new MyEvent(toy.Toy_Require_Event);

            ord.order(w);

        }
    }
}

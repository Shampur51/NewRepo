using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Pr4;

namespace WindowsFormsApp1
{
    public partial class File : Form
    {
        public File()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArraysAB a = new ArraysAB();

            FileWrite f = new FileWrite();

            FileRead f2 = new FileRead();

            ShowArray show = new ShowArray();

            string outx = @"outx.txt";
            string outy = @"outy.txt";
            string inx = @"inx.txt";
            string iny = @"iny.txt";

            f2.read(outx, outy, a);
            f.write(inx, iny, a);

            if (a.calculate() == true)
                Answer.Text = "Так";

            else
                Answer.Text = "Ні";

            arrX.Text = show.writeArray(a.a);
            arrY.Text = show.writeArray(a.b);
        }
    }
}

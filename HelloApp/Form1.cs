using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*1*/
        private void First_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(this.InputX.Text);
            double y = Convert.ToDouble(this.InputY.Text);
            double z = Convert.ToDouble(this.InputZ.Text);

            this.TextA.Text = "a = " + Convert.ToString((Math.Sqrt(Math.Abs(x - 1)) - Math.Sqrt(Math.Abs(y))) / (1 + (Math.Pow(2, x) / 2) + (Math.Pow(2, y) / 4)));
            this.TextB.Text = "b = " + Convert.ToString(x * (Math.Atan(z) + Math.Exp(1)));
        }
        //

        /*2*/
        private void Second_Click(object sender, EventArgs e)
        {
            double a, h;

            a = Convert.ToDouble(this.footing.Text);
            h = Convert.ToDouble(this.height.Text);

            this.square.Text = "S = " + Convert.ToString((a * a + 2 * a * h));
            this.volume.Text = "V = " + Convert.ToString(((a * a * h) / 3));
        }
        //

        /*3*/
        private void Third_Click(object sender, EventArgs e)
        {
            double[] num = new double[3];
            num[0] = Convert.ToDouble(this.InputA.Text);
            num[1] = Convert.ToDouble(this.InputB.Text);
            num[2] = Convert.ToDouble(this.InputC.Text);

            Array.Sort(num);
            this.TextMin.Text = "Min: " + Convert.ToString(num[0]);
            this.TextWane.Text = "Wane: " + Convert.ToString(num[2]) + ", " + Convert.ToString(num[1]) + ", " + Convert.ToString(num[0]);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

    }
}
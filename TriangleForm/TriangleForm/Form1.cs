using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double A, B, C, p, S;
                A = double.Parse(textBox1.Text);
                B = double.Parse(textBox2.Text);
                C = double.Parse(textBox3.Text);
                p = (A + B + C) / 2;
                S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
                p = A + B + C;
                label1.Text = S.ToString();
                label2.Text = p.ToString();
            }
            catch
            {
                MessageBox.Show("Укажите все стороны треугольника");
            }

        }

        private void Label1_Click(object sender, EventArgs e)  { }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            double A, B, C;
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("нет данных");
                return;
            }
            A = double.Parse(textBox1.Text);
            B = double.Parse(textBox2.Text);
            C = double.Parse(textBox3.Text); 
            OutPut(Triangle.P_Triangle);
            OutPut(Triangle.S_Triangle);
        }
        private void OutPut(Func<double, double, double, double> triangle)
        {
            label2.Text = Triangle.P_Triangle(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text)).ToString();
            label1.Text = Triangle.S_Triangle(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text)).ToString();
        }   
        private void Label1_Click(object sender, EventArgs e) { }
        private void Label5_Click(object sender, EventArgs e) { }
    }
}

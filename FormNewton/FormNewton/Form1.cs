using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormNewton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                MessageBox.Show("Error Empty");
            }

            label1.Text = Convert.ToString(MethodNewton(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
            if (string.IsNullOrWhiteSpace(textBox1 .Text))
            {
                MessageBox.Show("Error Empty");
            }
        }
         
        public static double MethodNewton(double degree, double radical,double eps = 0.0001)
        {
            if (degree < 0 || radical < 0)
            {
                MessageBox.Show("Отрицательное значение недопускается");
            }
           
           
            var x0 = radical / degree;
            var x1 = (1 / degree) * ((degree - 1) * x0 + radical / Math.Pow(x0, (int)degree - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / degree) * ((degree - 1) * x0 + radical / Math.Pow(x0, (int)degree - 1));
            }
            return x1;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

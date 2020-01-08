using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FormBinaryMethod
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
                if (string.IsNullOrWhiteSpace(textBox1.Text)) { }
                label1.Text = Convert.ToString("= "+BinaryMethod.SystemMethod(Convert.ToInt32(textBox1.Text))+"^2");
            }
            catch
            {
                MessageBox.Show("строка пустая или слишком большое число");
            }
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}


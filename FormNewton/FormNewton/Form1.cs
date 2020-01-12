using System;
using System.Windows.Forms;

namespace FormNewton
{
    

    public partial class Form1 : Form
    {
        /// <summary>
        /// кнопка при нажатии которой сначала проверяется не пустые ли Textbox'ы, 
        /// и конвертируем в string 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {    
           
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
            MessageBox.Show("нет данных или имеются отрицательные числа");
            return;
            }

            label1.Text = Convert.ToString(NewtonMethod.MethodNewton(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));   
        }
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(PowMethod.MethodNewtonPow(Convert.ToDouble(textBox1.Text),
                   Convert.ToDouble(textBox2.Text)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


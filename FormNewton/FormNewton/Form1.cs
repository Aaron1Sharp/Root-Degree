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
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text)) { }

                label1.Text = Convert.ToString(NewtonMethod.MethodNewton(Convert.ToDouble(textBox1.Text),
                    Convert.ToDouble(textBox2.Text))); 
            }
            catch 
            {
                MessageBox.Show("нет данных или имеются отрицательные числа"); 
                NewtonMethod.MethodNewton(0,0);
            }  
        }
        public class NewtonMethod
        {
            /// <summary>
            /// метод в котором проходит итерация
            /// </summary>
            /// <param name="degree">степень корня</param>
            /// <param name="radical">число внутри корня</param>
            /// <param name="eps">погрешность</param>
            /// <returns> возвращаем число полученное при Методе Ньютона </returns>
            public static double MethodNewton(double degree, double radical, double eps = 0.0001)
            {
                var x0 = radical / degree;
                var x1 = (1 / degree) * ((degree - 1) * x0 + radical / Math.Pow(x0, (int)degree - 1));
                if (radical < 0 || degree < 0)
                {
                    throw new Exception();
                }
                while (Math.Abs(x1 - x0) > eps)
                {
                    x0 = x1;
                    x1 = (1 / degree) * ((degree - 1) * x0 + radical / Math.Pow(x0, (int)degree - 1));
                }
                    return x1;   
            }
        }
        public Form1()
        {
            InitializeComponent();

        }
    }
}


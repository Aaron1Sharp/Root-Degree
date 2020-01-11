using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAlgorithmEuclidean
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds,
                    ts.TotalMilliseconds / 10);
            try
            {
                // ВСЕ ЧИСЛА В КОММЕНТАРИЯХ ВЫМЫШЛЕННЫЕ
                // AL = AlgorithmEuclidean
                // EM = EuclideanMethod
                // AL.EM(AL.EM(16, 36), AL.EM(585, 360));
                if (!string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox4.Text))
            { 
                stopwatch.Start();
                label1.Text = Convert.ToString(AlgorithmEuclidean.EuclideanMethod(AlgorithmEuclidean.EuclideanMethod(Convert.ToInt32(textBox1.Text),
                     Convert.ToInt32(textBox2.Text)), AlgorithmEuclidean.EuclideanMethod(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text))) + " = НОД из 4");
                stopwatch.Stop();
                    label2.Text = Convert.ToString(elapsedTime);
                }
                // AL.EM(36,60);
                else if (string.IsNullOrWhiteSpace(textBox3.Text) && string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    stopwatch.Start();
                    label1.Text = Convert.ToString(AlgorithmEuclidean.EuclideanMethod(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) + " = НОД из 2");
                    stopwatch.Stop();
                    label2.Text = Convert.ToString(elapsedTime);
                }
                // AL.EM(AL.EM(15, 30), 75);
                else if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    stopwatch.Start();
                    label1.Text = Convert.ToString(AlgorithmEuclidean.EuclideanMethod(AlgorithmEuclidean.EuclideanMethod(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)), Convert.ToInt32(textBox3.Text)) + " = НОД из 3");
                    stopwatch.Stop();
                    label2.Text = Convert.ToString(elapsedTime);
                }
           
       
            }
            catch
            {
                MessageBox.Show("Введите положительные числа по порядку минимум в первые два столбика");
            }


        }
        private void TextBox2_TextChanged(object sender, EventArgs e) { }
        private void TextBox1_TextChanged(object sender, EventArgs e) { }
    }
}
    



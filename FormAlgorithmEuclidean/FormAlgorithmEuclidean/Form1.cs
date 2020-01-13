using System;
using System.Windows.Forms;

namespace FormAlgorithmEuclidean
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        private void Button1_Click(object sender, EventArgs e)
        {
            // ВСЕ ЧИСЛА В КОММЕНТАРИЯХ ВЫМЫШЛЕННЫЕ
            // AL = AlgorithmEuclidean
            // EM = EuclideanMethod
            // AL.EM(AL.EM(16, 36), AL.EM(585, 360));
            if (CheckInputValues(firstnumber.Text)||CheckInputValues(secondnumber.Text))
            {
                MessageBox.Show("нет данных");
                return;
            }
            if (!string.IsNullOrWhiteSpace(thirdnumber.Text)
                && !string.IsNullOrWhiteSpace(fourthnumber.Text))
            {
                OutPut4value();
            }
            // AL.EM(36,60);
            else if (string.IsNullOrWhiteSpace(thirdnumber.Text)
                     && string.IsNullOrWhiteSpace(fourthnumber.Text))
            {
                OutPut2value();
            }

            // AL.EM(AL.EM(15, 30), 75);
            else if (string.IsNullOrWhiteSpace(fourthnumber.Text))
            {
                OutPut3value();
            }
        }
        #region
        private void OutPut4value() => output.Text = AlgorithmEuclidean.EuclideanMethod(AlgorithmEuclidean.EuclideanMethod(InputVariable(firstnumber.Text),InputVariable(secondnumber.Text)), AlgorithmEuclidean.EuclideanMethod(InputVariable(thirdnumber.Text), InputVariable(fourthnumber.Text))).ToString();
        private void OutPut2value() => output.Text = AlgorithmEuclidean.EuclideanMethod(InputVariable(firstnumber.Text),InputVariable(secondnumber.Text)).ToString();
        private void OutPut3value() => output.Text = AlgorithmEuclidean.EuclideanMethod(AlgorithmEuclidean.EuclideanMethod(InputVariable(firstnumber.Text), InputVariable(secondnumber.Text)),InputVariable(thirdnumber.Text)).ToString();
        private int InputVariable(string value) => int.Parse(value);
        private bool CheckInputValues(string value) => string.IsNullOrEmpty(value) || Convert.ToDouble(value) < 0;
        private void TextBox2_TextChanged(object sender, EventArgs e) { }
        private void TextBox1_TextChanged(object sender, EventArgs e) { }
        #endregion
    }
}
    



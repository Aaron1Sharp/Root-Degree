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
        public Form1() => InitializeComponent();
        private void Button1_Click(object sender, EventArgs e)
        {
            if (CheckInputValues(InputA.Text)
                || CheckInputValues(InputB.Text)
                || CheckInputValues(InputC.Text))
            {
                MessageBox.Show("нет данных");
                return;
            }
            OutPut();
        }
        private void OutPut()
        {
            OutputS.Text = Triangle.FindP(InputVariable(InputA.Text),
                                          InputVariable(InputB.Text),
                                          InputVariable(InputC.Text)).ToString();

            OutputP.Text = Triangle.FindS(InputVariable(InputA.Text),
                                          InputVariable(InputB.Text),
                                          double.Parse(InputC.Text)).ToString();
        }
        private double InputVariable(string value) => double.Parse(value);
        private bool CheckInputValues(string value) => string.IsNullOrEmpty(value) || Convert.ToDouble(value) < 0;
        private void Label1_Click(object sender, EventArgs e) { }
        private void Label5_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}

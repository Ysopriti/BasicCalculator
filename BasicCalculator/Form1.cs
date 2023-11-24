using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatePrivateAssembly;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1, num2;
        private void btnCompute_Click(object sender, EventArgs e)
        {
            
            float num1 = (float)Convert.ToDouble(txtBoxNum1.Text);
            float num2 = (float)Convert.ToDouble(txtBoxNum2.Text);

            if (btnCompute.Text == "+")
            {
                float result = BasicComputation.Addition(num1, num2);
                string Result = result.ToString();
                txtBoxNum3.Text = Result;

            }
            else if (btnCompute.Text == "-")
            {
                float result = BasicComputation.Subtraction(num1, num2);
                string Result = result.ToString();
                txtBoxNum3.Text = Result;

            }
            else if (btnCompute.Text == "*")
            {
                float result = BasicComputation.Multiplication(num1, num2);
                string Result = result.ToString();
                txtBoxNum3.Text = Result;

            }
            else if (btnCompute.Text == "/")
            {
                float result = BasicComputation.Division(num1, num2);
                string Result = result.ToString();
                txtBoxNum3.Text = Result;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}

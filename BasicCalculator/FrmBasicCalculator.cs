using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {

            try
            {
                float num1 = float.Parse(txtNum1.Text);
                float num2 = float.Parse(txtNum2.Text);
                string operation = cbOperation.SelectedItem.ToString();
                float result = 0;

                switch (operation)
                {
                    case "+":
                        result = BasicComputation.Add(num1, num2);
                        break;
                    case "-":
                        result = BasicComputation.Subtract(num1, num2);
                        break;
                    case "*":
                        result = BasicComputation.Multiply(num1, num2);
                        break;
                    case "/":
                        result = BasicComputation.Divide(num1, num2);
                        break;
                    default:
                        MessageBox.Show("Please select a valid operation.");
                        return;
                }

                lblResult.Text = $"Result: {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

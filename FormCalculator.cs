using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        private string firstOperand = "";
        private string secondOperand = "";
        private string currentOperator = "";
        private bool isResultShown = false;
        private double mem=0;
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add event handlers to your buttons
            btn0.Click += NumberButton_Click;
            btn1.Click += NumberButton_Click;
            btn2.Click += NumberButton_Click;
            btn3.Click += NumberButton_Click;
            btn4.Click += NumberButton_Click;
            btn5.Click += NumberButton_Click;
            btn6.Click += NumberButton_Click;
            btn7.Click += NumberButton_Click;
            btn8.Click += NumberButton_Click;
            btn9.Click += NumberButton_Click;
            btnDot.Click += NumberButton_Click;
            btnPercent.Click += NumberButton_Click;
            btnC.Click += btnC_Click;
            btnCE.Click += btnCE_Click;
            btnMC.Click += btnMC_Click;
            btnMR.Click += btnMR_Click;
            btnMPlus.Click += btnMPlus_Click;
            btnMMinus.Click += btnMMinus_Click;

            btnDivide.Click += OperatorButton_Click;
            btnMultiply.Click += OperatorButton_Click;
            btnMinus.Click += OperatorButton_Click;
            btnPlus.Click += OperatorButton_Click;

            btnEqual.Click += btnEqual_Click;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                ClearEquation();
                isResultShown = false;
            }

            Guna2Button button = (Guna2Button)sender;

            if (currentOperator == "")
            {
                firstOperand += button.Text;
                labelEqn.Text = firstOperand;
            }
            else
            {
                secondOperand += button.Text;
                labelEqn.Text = firstOperand + " " + currentOperator + " " + secondOperand;
            }
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                isResultShown = false;
            }

            Guna2Button button = (Guna2Button)sender;
            string operat = button.Text;

            if (button.Text == "×")
                    operat = "*"; 
            else if(button.Text== "÷")
                operat = "/";
                


            if (currentOperator == "")
            {
                currentOperator = operat;
                labelEqn.Text = firstOperand + " " + currentOperator;
            }
            else
            {
                try
                {
                    Compute();
                    firstOperand = labelAns.Text;
                    currentOperator = operat;
                    secondOperand = "";
                    labelEqn.Text = firstOperand + " " + currentOperator;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                Compute();
                currentOperator = "";
                secondOperand = "";
                isResultShown = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Compute()
        {
            if (firstOperand != "" && secondOperand != "" && currentOperator != "")
            {
                var result = new DataTable().Compute(firstOperand + currentOperator + secondOperand, null);
                labelAns.Text = result.ToString();
                firstOperand = result.ToString();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ClearEquation();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (currentOperator == "")
            {
                ClearEquation();
            }
            else
            {
                secondOperand = "";
                labelEqn.Text = firstOperand + " " + currentOperator;
            }
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            mem = 0;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            firstOperand = mem.ToString();
            labelEqn.Text = firstOperand;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(labelEqn.Text, out value))
            {
                mem += value;
            }
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(labelEqn.Text, out value))
            {
                mem -= value;
            }
        }
        private void ClearEquation()
        {
            firstOperand = "";
            secondOperand = "";
            currentOperator = "";
            labelEqn.Text = "";
            labelAns.Text = "";
        }

    }
}


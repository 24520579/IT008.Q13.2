using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        private double operand1 = 0;
        private string operation = null;
        private bool isNewInput = true;

        public Form1()
        {
            InitializeComponent();
            ResetCalculator();
        }

        private void ResetCalculator()
        {
            lbNow.Text = "0";
            lbMem.Text = "";
            operand1 = 0;
            operation = null;
            isNewInput = true;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string digit = btn.Text;

            if (isNewInput)
            {
                lbNow.Text = digit;
                isNewInput = false;
            }
            else
            {
                if (lbNow.Text == "0")
                    lbNow.Text = digit;
                else
                    lbNow.Text += digit;
            }
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (!isNewInput)
            {
                btnEquals_Click(null, null);
            }

            Button btn = sender as Button;
            operand1 = double.Parse(lbNow.Text);
            operation = btn.Text;
            lbMem.Text = $"{operand1} {operation}";
            isNewInput = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (operation == null || isNewInput)
            {
                return;
            }

            double operand2 = double.Parse(lbNow.Text);
            double result = 0;

            lbMem.Text = $"{operand1} {operation} {operand2} =";

            switch (operation)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "x":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        lbNow.Text = "Error";
                        isNewInput = true;
                        operation = null;
                        return;
                    }
                    result = operand1 / operand2;
                    break;
            }

            lbNow.Text = result.ToString();
            operand1 = result;
            operation = null;
            isNewInput = true;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                lbNow.Text = "0.";
                isNewInput = false;
            }
            else if (!lbNow.Text.Contains("."))
            {
                lbNow.Text += ".";
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(lbNow.Text, out val))
            {
                if (val < 0)
                {
                    lbNow.Text = "Error";
                }
                else
                {
                    val = Math.Sqrt(val);
                    lbNow.Text = val.ToString();
                }
            }
            isNewInput = true;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (lbNow.Text.Length > 1)
            {
                lbNow.Text = lbNow.Text.Substring(0, lbNow.Text.Length - 1);
            }
            else
            {
                lbNow.Text = "0";
                isNewInput = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetCalculator();
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            lbNow.Text = "0";
            isNewInput = true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1,operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Num0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }
         
        private void Num1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void Dec_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }


        private void Subtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if(operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if(operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if(operation =='/')
            {
                if(num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Invalid";
                }
            }
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Squared_Click(object sender, EventArgs e)
        {
            operand1 = input;
            double num;
            double.TryParse(operand1, out num);

            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;

            result = num * num;
            this.input = result.ToString();
            this.textBox1.Text = input;
        }

        private void SquareRoot_Click(object sender, EventArgs e)
        {
            operand1 = input;
            double num;
            double.TryParse(operand1, out num);

            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;

            result = Math.Sqrt(num);
            this.input = result.ToString();
            this.textBox1.Text = input;
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            operand1 = input;
            double num;
            double.TryParse(operand1, out num);

            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;

            result = Math.Sin(num);
            textBox1.Text = result.ToString();
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            operand1 = input;
            double num;
            double.TryParse(operand1, out num);

            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;

            result = Math.Cos(num);
            textBox1.Text = result.ToString();
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            operand1 = input;
            double num;
            double.TryParse(operand1, out num);

            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;

            result = Math.Tan(num);
            textBox1.Text = result.ToString();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }


    }
}

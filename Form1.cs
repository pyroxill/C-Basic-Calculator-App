using System.Security.Cryptography.Xml;

namespace CalculatorForm
//Author: Jayden Robertson
//Date: 09/03/2025
//Description: A simple calculator that performs addition, subtraction, multiplication and division
{
    public partial class Form1 : Form
    {
        //Declare variables to store input, operands and result
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        //Clears the text box and resets the input, operand1 and operand2
        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        //Sets the operation to multiplication and stores the first operand once the multiply button is clicked
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        //Sets the operation to division and stores the first operand once the divide button is clicked
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        //Calculates the result of the operation when the equals button is clicked
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            //Perform the mathematical operation based on the operator
            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString(); //Display the result
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString(); //Display the result
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString(); //Display the result
            }
            else if (operation == '/')
            {
                result = num1 / num2;
                textBox1.Text = result.ToString(); //Display the result
            }
            else
            {
                textBox1.Text = "Invalid Operation"; //Display error message
            }
        }

        //Sets the operation to subtraction and stores the first operand once the subtract button is clicked
        private void buttonSubtract_Click(object sender, EventArgs e)
        {
           operand1 = input;
           operation = '-';
           input = string.Empty;
        }

        //Adds the number 0 to the input string when the button is clicked
        private void button0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        //Adds the number 1 to the input string when the button is clicked
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        //Adds the number 1 to the input string when the button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        //Adds the number 2 to the input string when the button is clicked
        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        //Adds the number 3 to the input string when the button is clicked
        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        //Adds the number 4 to the input string when the button is clicked
        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        //Adds the number 5 to the input string when the button is clicked
        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        //Adds the number 6 to the input string when the button is clicked
        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        //Adds the number 7 to the input string when the button is clicked
        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        //Adds the number 8 to the input string when the button is clicked
        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        //Adds the number 9 to the input string when the button is clicked
        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }
    }
}

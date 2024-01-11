namespace rekenmachine
{
    public partial class Form1 : Form
    {

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (input == string.Empty)
            {
                return;
            }
            operand1 = input;
            operation = '-';
            input = string.Empty;
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            this.richTextBox1.Text = $"{num1} {operation} {num2}";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (input == string.Empty)
            {
                return;
            }
            operand1 = input;
            operation = 'x';
            input = string.Empty;
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            this.richTextBox1.Text = $"{num1} {operation} {num2}";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                this.input = result.ToString();
                richTextBox1.Text = result.ToString();
                richTextBox2.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                this.input = result.ToString();
                richTextBox1.Text = result.ToString();
                richTextBox2.Text = result.ToString();
            }
            else if (operation == 'x')
            {
                result = num1 * num2;
                this.input = result.ToString();
                richTextBox1.Text = result.ToString();
                richTextBox2.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    this.input = result.ToString();
                    richTextBox1.Text = result.ToString();
                    richTextBox2.Text = result.ToString();
                }
                else
                {
                    richTextBox1.Text = "DIV!";
                    richTextBox2.Text = "DIV!";
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                input = input.Substring(0, input.Length - 1);
                this.richTextBox1.Text = input;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            this.richTextBox2.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (input == string.Empty)
            {
                return;
            }
            operand1 = input;
            operation = '+';
            input = string.Empty;
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            this.richTextBox1.Text = $"{num1} {operation} {num2}";

        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            if (input == string.Empty)
            {
                return;
            }
            operand1 = input;
            operation = '/';
            input = string.Empty;
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            this.richTextBox1.Text = $"{num1} {operation} {num2}";
        }
        private void UpdateInputDisplay()
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.richTextBox2.Text = $"{num1} {operation} {num2}";
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            this.richTextBox2.Text = $"{operand1} {operation} {input}";
        }

        private void nothing1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.richTextBox2.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.operation = ' ';
        }

        private void button_click(object sender, EventArgs e)
        {
            var ButtonText = (sender as Button).Text;
            this.richTextBox1.Text = "";
            input += ButtonText;
            this.richTextBox1.Text += input;
            this.richTextBox2.Text += input;            
        }
    }
}

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

        private void zero_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "1";
            this.richTextBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "2";
            this.richTextBox1.Text += input;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "3";
            this.richTextBox1.Text += input;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "4";
            this.richTextBox1.Text += input;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "5";
            this.richTextBox1.Text += input;
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "6";
            this.richTextBox1.Text += input;
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

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "7";
            this.richTextBox1.Text += input;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "8";
            this.richTextBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "9";
            this.richTextBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "0";
            this.richTextBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {

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
        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

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

        private void Form1_Load(object sender, EventArgs e)
        {
            // 
        }

        private void buttongea_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "9";
            this.richTextBox1.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "0";
            this.richTextBox1.Text += input;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void nothing2_Click(object sender, EventArgs e)
        {
            //
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
    }
}

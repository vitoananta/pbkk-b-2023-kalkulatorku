namespace KalkulatorKu
{
    public partial class Form1 : Form
    {
        string stringResult;
        Double number1;
        Double number2;
        Double result;
        string option;

        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            number1 = Double.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            number1 = Double.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            option = "*";
            number1 = Double.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            option = "/";
            number1 = Double.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            number2 = Double.Parse(textBox1.Text);

            if (option.Equals("+"))
            {
                result = number1 + number2;
            }

            if (option.Equals("-"))
            {
                result = number1 - number2;
            }

            if (option.Equals("*"))
            {
                result = number1 * number2;
            }

            if (option.Equals("/"))
            {
                result = number1 / number2;
            }

            textBox1.Text = result + "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = (0);
            number1 = (0);
            number2 = (0);
        }

        private void buttonFloat_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text + "";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
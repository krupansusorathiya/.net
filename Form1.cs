using System;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        int first_no;
        string op = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Handle button 8 click event if necessary
        }

        private void eqqual_Click(object sender, EventArgs e)
        {
            int second_no;
            int ans;
            second_no = Convert.ToInt32(textBox1.Text);

            if (op == "+")
            {
                ans = first_no + second_no;
                textBox1.Text = ans.ToString();
                first_no = ans;
            }
            if (op == "-")
            {
                ans = first_no - second_no;
                textBox1.Text = ans.ToString();
                first_no = ans;
            }
            if (op == "*")
            {
                ans = first_no * second_no;
                textBox1.Text = ans.ToString();
                first_no = ans;
            }
            if (op == "/")
            {
                ans = first_no / second_no;
                textBox1.Text = ans.ToString();
                first_no = ans;
            }
        }

        private void slash_Click(object sender, EventArgs e)
        {
            first_no = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            op = "/";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            first_no = 0;
            op = "";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "0";
            }
        }

        private void mult_Click(object sender, EventArgs e)
        {
            first_no = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            op = "*";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void substract_Click(object sender, EventArgs e)
        {
            first_no = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            op = "-";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            first_no = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            op = "+";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (!int.TryParse(textBox1.Text, out _))
                {
                    MessageBox.Show("Please enter only numeric values.");
                    textBox1.Text = "0";
                }
            }
        }
    }
}

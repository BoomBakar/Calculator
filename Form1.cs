using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double n1;
        char oper;
        public Form1()
        {
            InitializeComponent();
        }


   
    
    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_for1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button_for2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button_for3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button_for4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button_for5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button_for7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button_for8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button_for9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button_for0_Click(object sender, EventArgs e)
        {
           
            textBox1.Text += "0";
            
        }

        private void Equal_Button_Click(object sender, EventArgs e)
        {
            double n2;
            double calc;

            n2 = Convert.ToDouble(textBox1.Text);

            switch(oper)
            {
                case '+':
                    calc = n1 + n2;
                    textBox1.Text = Convert.ToString(calc);
                    n1 = calc;
                    break;
                case '-':
                    calc = n1 - n2;
                    textBox1.Text = Convert.ToString(calc);
                    n1 = calc;
                    break;
                case '*':
                    calc = n1 * n2;
                    textBox1.Text = Convert.ToString(calc);
                    n1 = calc;
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        textBox1.Text = "Cannot divide by zero";

                    }
                    else
                    {
                        calc = (n1 / n2);
                        textBox1.Text = Convert.ToString(calc);
                        n1 = calc;
                    }
                    break;
                case '^':
                    calc = n1 * n1;
                    textBox1.Text = Convert.ToString(calc);
                    n1 = calc;
                    break;
                case '%':
                    calc = n1 % n2;
                    textBox1.Text = Convert.ToString(calc);
                    n1 = calc;
                    break;
                default:
                    break;
            }
            
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = '+';
        }

        private void Sub_Button_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = '-';
        }

        private void Multiply_Button_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = '*';
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = '/';
        }

        private void Dot_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void Square_Button_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = '^';
        }

        private void Mod_Button_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = '%';
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                string data = "0";
                data = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                textBox1.Text = data;

            }
        }
    }
}

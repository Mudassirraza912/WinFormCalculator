using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCalculator
{
    public partial class Form1 : Form
    {
        int value = 0;
        char oprator;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oprator = '/';
            if (string.IsNullOrEmpty(inpDisplay.Text))
            {
                return;
            }
            value = string.IsNullOrEmpty(inpDisplay.Text) ? 0 : Convert.ToInt32(inpDisplay.Text);
            inpDisplay.Text = "";

        }

        private void inpDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            inpDisplay.Text = "";
            oprator = default;
            value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inpDisplay.Text += "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            inpDisplay.Text += "9";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            inpDisplay.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            inpDisplay.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            inpDisplay.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            inpDisplay.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            inpDisplay.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            inpDisplay.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            inpDisplay.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            inpDisplay.Text += "8";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            oprator = '+';
            if(string.IsNullOrEmpty(inpDisplay.Text))
            {
                return;
            }
            value = string.IsNullOrEmpty(inpDisplay.Text) ? 0 : Convert.ToInt32(inpDisplay.Text);
            inpDisplay.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(inpDisplay.Text) == false)
            {
                if(oprator == '+')
                {
                    inpDisplay.Text = Convert.ToString(value + Convert.ToInt32(inpDisplay.Text));
                    oprator = default;
                }else if (oprator == '-')
                {
                    inpDisplay.Text = Convert.ToString(value - Convert.ToInt32(inpDisplay.Text));
                    oprator = default;
                }else if (oprator == 'x')
                {
                    inpDisplay.Text = Convert.ToString(value * Convert.ToInt32(inpDisplay.Text));
                    oprator = default;
                }else if (oprator == '/')
                {
                    inpDisplay.Text = Convert.ToInt32(inpDisplay.Text) == 0 ? "Cannot divide by zero" : Convert.ToString(value / Convert.ToInt32(inpDisplay.Text));
                    oprator = default;
                }else
                {
                    return;
                }

                value = 0;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            oprator = '-';
            if (string.IsNullOrEmpty(inpDisplay.Text))
            {
                return;
            }
            value = string.IsNullOrEmpty(inpDisplay.Text) ? 0 : Convert.ToInt32(inpDisplay.Text);
            inpDisplay.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            oprator = 'x';
            if (string.IsNullOrEmpty(inpDisplay.Text))
            {
                return;
            }
            value = string.IsNullOrEmpty(inpDisplay.Text) ? 0 : Convert.ToInt32(inpDisplay.Text);
            inpDisplay.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

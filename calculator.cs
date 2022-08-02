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
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        float num, ans;
        int count;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_main.Text = textBox_main.Text + 1;
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            textBox_main.Text = textBox_main.Text + 2;
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            textBox_main.Text = textBox_main.Text + 3;
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            textBox_main.Text = textBox_main.Text + 4;
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            textBox_main.Text = textBox_main.Text + 5;
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            textBox_main.Text = textBox_main.Text + 6;
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            textBox_main.Text = textBox_main.Text + 7;
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            textBox_main.Text = textBox_main.Text + 8;
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            textBox_main.Text = textBox_main.Text + 9;
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            textBox_main.Text = textBox_main.Text + 0;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int length = textBox_main.TextLength - 1;
            string text = textBox_main.Text;
            textBox_main.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox_main.Text = textBox_main.Text + text[i];
            }
        }

        private void btn_delete_all_Click(object sender, EventArgs e)
        {
            textBox_main.Text = "";
        }

        private void btn_devide_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox_main.Text);
            textBox_main.Clear();
            textBox_main.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox_main.Text);
            textBox_main.Clear();
            textBox_main.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox_main.Text);
            textBox_main.Clear();
            textBox_main.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox_main.Text);
            textBox_main.Clear();
            textBox_main.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }

        private void btn_comma_Click(object sender, EventArgs e)
        {
            textBox_main.Text = textBox_main.Text + ".";
        }


        public void compute()
        {
            switch (count)
            {
                case 1:

                    ans = num + float.Parse(textBox_main.Text);
                    textBox_main.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(textBox_main.Text);
                    textBox_main.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textBox_main.Text);
                    textBox_main.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textBox_main.Text);
                    textBox_main.Text = ans.ToString();
                    break;
                default:
                    break;


            }
        }
    }
}

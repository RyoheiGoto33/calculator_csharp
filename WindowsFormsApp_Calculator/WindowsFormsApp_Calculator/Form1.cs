using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Calculator
{
    public partial class Form1 : Form
    {
        double text_input=0,text_output=0,cal=0;
        int text_output_flg = 0;
        /// <summary>
        /// フォームのコンストラクタ
        /// フォームの起動時に一度だけ呼び出される
        /// </summary>
        public Form1()
        {
            // フォームの初期化処理
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_result_Click(object sender, EventArgs e)
        {

        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (cal == 0)
            {
                text_input *= 10;
                text_input += 7;
                textBox_input.Text = text_input.ToString();
            }
            else
            {
                if (text_output_flg == 0)
                {
                    text_output = text_input;
                    text_input = 0;
                    textBox_result.Text = text_output.ToString();
                    textBox_input.Text = text_input.ToString();
                    text_output_flg++;
                }
                text_input *= 10;
                text_input += 7;
                textBox_input.Text = text_input.ToString();
            }
        }
        private void textBox_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            if (cal == 1)
            {
                text_output = text_input + text_output;
                text_input = 0;
                textBox_result.Text = text_output.ToString();
            }
            else if (cal == 2)
            {
                text_output = text_output - text_input;
                text_input = 0;
                textBox_result.Text = text_output.ToString();
            }
            else if (cal == 3)
            {
                text_output = text_output * text_input;
                text_input = 0;
                textBox_result.Text = text_output.ToString();
            }
            else if (cal == 4)
            {
                text_output = text_output / text_input;
                text_input = 0;
                textBox_result.Text = text_output.ToString();
            }
            else
                MessageBox.Show("演算子がクリックされていません。");
        }

        private void button_addition_Click(object sender, EventArgs e)
        {
            cal = 1;
        }

        private void button_subtracion_Click(object sender, EventArgs e)
        {
            cal = 2;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (cal == 0)
            {
                text_input *= 10;
                text_input += 3;
                textBox_input.Text = text_input.ToString();
            }
            else
            {
                if (text_output_flg == 0)
                {
                    text_output = text_input;
                    text_input = 0;
                    textBox_result.Text = text_output.ToString();
                    textBox_input.Text = text_input.ToString();
                    text_output_flg++;
                }
                text_input *= 10;
                text_input += 3;
                textBox_input.Text = text_input.ToString();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_input = 0;
            text_output = 0;
            textBox_input.Text = text_input.ToString();
            textBox_result.Text = text_output.ToString();
            text_output_flg = 0;
            cal = 0;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (cal == 0)
            {
                text_input *= 10;
                textBox_input.Text = text_input.ToString();
            }
            else
            {
                if (text_output_flg == 0)
                {
                    text_output = text_input;
                    text_input = 0;
                    textBox_result.Text = text_output.ToString();
                    textBox_input.Text = text_input.ToString();
                    text_output_flg++;
                }
                text_input *= 10;
                textBox_input.Text = text_input.ToString();
            }
        }
        private void button_1_Click(object sender, EventArgs e)
        {            if (cal == 0)
            {
                text_input *= 10;
                text_input += 1;
                textBox_input.Text = text_input.ToString();
            }
            else
            {
                if (text_output_flg == 0)
                {
                    text_output = text_input;
                    text_input = 0;
                    textBox_result.Text = text_output.ToString();
                    textBox_input.Text = text_input.ToString();
                    text_output_flg++;
                }
                text_input *= 10;
                text_input += 1;
                textBox_input.Text = text_input.ToString();
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (cal == 0)
            {
                text_input *= 10;
                text_input += 2;
                textBox_input.Text = text_input.ToString();
            }
            else
            {
                if (text_output_flg == 0)
                {
                    text_output = text_input;
                    text_input = 0;
                    textBox_result.Text = text_output.ToString();
                    textBox_input.Text = text_input.ToString();
                    text_output_flg++;
                }
                text_input *= 10;
                text_input += 2;
                textBox_input.Text = text_input.ToString();
            }
        }
        private void button_4_Click(object sender, EventArgs e)
        {
            if (cal == 0)
            {
                text_input *= 10;
                text_input += 4;
                textBox_input.Text = text_input.ToString();
            }
            else
            {
                if (text_output_flg == 0)
                {
                    text_output = text_input;
                    text_input = 0;
                    textBox_result.Text = text_output.ToString();
                    textBox_input.Text = text_input.ToString();
                    text_output_flg++;
                }
                text_input *= 10;
                text_input += 4;
                textBox_input.Text = text_input.ToString();
            }
        }
        private void button_5_Click(object sender, EventArgs e)
        {
            if (cal == 0)
            {
                text_input *= 10;
                text_input += 5;
                textBox_input.Text = text_input.ToString();
            }
            else
            {
                if (text_output_flg == 0)
                {
                    text_output = text_input;
                    text_input = 0;
                    textBox_result.Text = text_output.ToString();
                    textBox_input.Text = text_input.ToString();
                    text_output_flg++;
                }
                text_input *= 10;
                text_input += 5;
                textBox_input.Text = text_input.ToString();
            }
        }
        private void button_6_Click(object sender, EventArgs e)
        {
            if (cal == 0)
            {
                text_input *= 10;
                text_input += 6;
                textBox_input.Text = text_input.ToString();
            }
            else
            {
                if (text_output_flg == 0)
                {
                    text_output = text_input;
                    text_input = 0;
                    textBox_result.Text = text_output.ToString();
                    textBox_input.Text = text_input.ToString();
                    text_output_flg++;
                }
                text_input *= 10;
                text_input += 6;
                textBox_input.Text = text_input.ToString();
            }
        }
        private void button_8_Click(object sender, EventArgs e)
        {
            if (cal == 0)
            {
                text_input *= 10;
                text_input += 8;
                textBox_input.Text = text_input.ToString();
            }
            else
            {
                if (text_output_flg == 0)
                {
                    text_output = text_input;
                    text_input = 0;
                    textBox_result.Text = text_output.ToString();
                    textBox_input.Text = text_input.ToString();
                    text_output_flg++;
                }
                text_input *= 10;
                text_input += 8;
                textBox_input.Text = text_input.ToString();
            }
        }

        private void button_multiplication_Click(object sender, EventArgs e)
        {
            cal = 3;
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            cal = 4;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (cal == 0)
            {
                text_input *= 10;
                text_input += 9;
                textBox_input.Text = text_input.ToString();
            }
            else
            {
                if (text_output_flg == 0)
                {
                    text_output = text_input;
                    text_input = 0;
                    textBox_result.Text = text_output.ToString();
                    textBox_input.Text = text_output.ToString();
                    text_output_flg++;
                }
                text_input *= 10;
                text_input += 9;
                textBox_input.Text = text_input.ToString();
            }
        }
    }
}

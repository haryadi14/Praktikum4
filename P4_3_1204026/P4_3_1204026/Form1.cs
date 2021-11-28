using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P4_3_1204026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                epWarning.SetError(textBox1, "Textbox Huruf tidak boleh kosong !!");
                epWrong.SetError(textBox1, "");
                epCorrect.SetError(textBox1, "");
            }
            else
            {

                if ((textBox1.Text).All(char.IsLetter))
                {
                    epWarning.SetError(textBox1, "");
                    epWrong.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "Betul");
                }
                else
                {
                    epWarning.SetError(textBox1, "");
                    epWrong.SetError(textBox1, "Inputan hanya boleh huruf");
                    epCorrect.SetError(textBox1, "");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                epWarning.SetError(textBox2, "Textbox Huruf tidak boleh kosong !!");
                epWrong.SetError(textBox2, "");
                epCorrect.SetError(textBox2, "");
            }
            else
            {
                if ((textBox2.Text).All(char.IsNumber))
                {
                    epWarning.SetError(textBox2, "");
                    epWrong.SetError(textBox2, "");
                    epCorrect.SetError(textBox2, "Betul");
                }
                else
                {
                    epWarning.SetError(textBox2, "");
                    epWrong.SetError(textBox2, "Inputan hanya boleh Angka");
                    epCorrect.SetError(textBox2, "");
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                epWarning.SetError(textBox3, "Textbox Huruf tidak boleh kosong !!");
                epWrong.SetError(textBox3, "");
                epCorrect.SetError(textBox3, "");
            }
            else
            {
                if (Regex.IsMatch(textBox3.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {

                    epWarning.SetError(textBox3, "");
                    epWrong.SetError(textBox3, "");
                    epCorrect.SetError(textBox3, "Betul");
                }
                else
                {
                    epWarning.SetError(textBox3, "");
                    epWrong.SetError(textBox3, "Format salah ! \nContoh : haryadi@gmail.com");
                    epCorrect.SetError(textBox3, "");
                }
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {


            if ((textBox4.Text).All(Char.IsNumber))
            {
                if (textBox4.Text == "")
                {
                    epWarning.SetError(textBox4, "Angka 2 Belum terisi");
                }

                else
                {
                    epCorrect.SetError(textBox4, "Angka 2 Terisi");
                }
            }

            else if (textBox4.Text == "")
            {
                epWarning.SetError(textBox4, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(textBox4, "inputan hanya boleh Angka!");
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if ((textBox5.Text).All(Char.IsNumber))
            {
                int Angka1 = int.Parse(textBox5.Text);
                int Angka2 = int.Parse(textBox5.Text);
                if (Angka1 > Angka2)
                {
                    epCorrect.SetError(textBox5, "Angka 1 lebih besar dari angka 2 ");
                }
            }

            else if ((textBox5.Text == ""))
            {
                epWarning.SetError(textBox5, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(textBox5, "inputan hanya boleh Angka!");
            }
        }
    }
    }


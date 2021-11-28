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

namespace P4_4_1204026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_Leave(object sender, EventArgs e)
        {

        }

        

        private void tbNum_Leave(object sender, EventArgs e)
        {
            int tbnumval;

            if (int.TryParse(tbNum.Text, out tbnumval))
            {
                epBenar.SetError(tbNum, "Benar");
            }

            else
            {
                epSalah.SetError(tbNum, "Harus Diisi");
            }

        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbNama_Leave(object sender, EventArgs e)
        {
            if (tbNama.Text != "")
            {
                epBenar.SetError(tbNama, " NAMA VALID");
            }
            else
            {
                epSalah.SetError(tbNama, " HARUS DIISI");
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epBenar.SetError(tbEmail, "Benar!");
            }
            else
            {
                epSalah.SetError(tbEmail, "Format salah !\nContoh: haryadi@gmail.com");
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text.All(char.IsUpper))
            {
                epBenar.SetError(textBox4, "Benar");
            }
            else
            {
                epSalah.SetError(textBox4, "Harus UPPERCASE");
            }
        }

        private void tbPswd_Leave(object sender, EventArgs e)
        {
            if (tbPswd.Text != "")
            {
                int length = tbPswd.Text.Length;
                if (length > 6)
                {
                    epBenar.SetError(tbPswd, "Password Valid");
                }
                else
                {
                    epSalah.SetError(tbPswd, "Password Erorr");
                }

            }
            else
            {
                epSalah.SetError(tbPswd, "Silahkan Diisi");
            }
        }

        private void tbGaji1_Leave(object sender, EventArgs e)
        {
            if ((tbGaji1.Text).All(Char.IsNumber))
            {
            }

            else if (tbGaji1.Text == "")
            {
                epSalah.SetError(tbGaji1, "Textbox  tidak boleh kosong");

            }

            else
            {
                epSalah.SetError(tbGaji1, "inputan hanya berupa Angka!");
            }
        }

        private void tbGaji2_Leave(object sender, EventArgs e)
        {
            if ((tbGaji2.Text).All(Char.IsNumber))
            {
                int Gaji1;
                int Gaji2;
                int.TryParse(tbGaji1.Text, out Gaji1);
                int.TryParse(tbGaji2.Text, out Gaji2);
                if (Gaji1 > Gaji2)
                {
                    epBenar.SetError(tbGaji1, "Angka 1 lebih besar dari Gaji 2 ");
                    epSalah.SetError(tbGaji2, "Angka 2 lebih kecil dari Gaji 1 ");
                }

                else
                {
                    epBenar.SetError(tbGaji1, "Gaji 2 lebih besar dari Gaji 1 ");
                    epSalah.SetError(tbGaji2, "Gaji 1 lebih kecil dari Gaji 2 ");
                }
            }

            else if (tbGaji2.Text == "")
            {
                epSalah.SetError(tbGaji2, "Textbox  tidak boleh kosong");

            }

            else
            {
                epSalah.SetError(tbGaji2, "inputan hanya berupa Angka!");
            }
        }

        private void tbJabatan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbJabatan_Leave(object sender, EventArgs e)
        {
            if (tbJabatan.Text.All(char.IsLower))
            {
                epBenar.SetError(tbJabatan, "Benar");
            }
            else
            {
                epSalah.SetError(tbJabatan, "Harus LOWERCASE");
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No. Whatsapp : " + tbNum.Text + "\nNama : " + tbNama.Text + "\nEmail : " + tbEmail.Text + "\nPerbandingan Gaji : " + tbGaji1.Text + " " + tbGaji2.Text + "\nPassword : " + tbPswd.Text + "\nUsername dalam UPPERCASE : " + textBox4.Text + "\njabatan dalam lowercase : " + tbJabatan.Text);

        }
    }
    }


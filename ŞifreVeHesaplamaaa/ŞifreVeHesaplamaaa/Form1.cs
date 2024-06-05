using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞifreVeHesaplamaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int karakter = textBox2.Text.Length;
            if (karakter > 0 && karakter < 4)
            {
                progressBar1.Value = 1;
                progressBar1.ForeColor = Color.Red;
                label3.Text = "Zayıf";
            }
            else if (karakter >= 4 && karakter < 8)
            {
                progressBar1.Value = 2;
                progressBar1.ForeColor = Color.Yellow;
                label3.Text = "Orta";
            }
            else if (karakter >= 8)
            {
                progressBar1.Value = 3;
                progressBar1.ForeColor = Color.Green;
                label3.Text = "Güçlü";
            }
            else
            {
                progressBar1.Value = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox3.Text);
            int sayi2 = Convert.ToInt32(textBox4.Text);
            int sonuc;
            if (radioButton1.Checked == true)
            {
                label5.Text = (sayi1 + sayi2).ToString();
            }
            else if (radioButton2.Checked == true)
            {
                label5.Text = (sayi1 - sayi2).ToString();
            }
            else if (radioButton3.Checked == true)
            {
                label5.Text = (sayi1 * sayi2).ToString();
            }
            else
            {
                label5.Text = (sayi1 / sayi2).ToString();
            }
        }
    }
}
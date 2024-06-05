using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swith_Hesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToByte(textBox1.Text);
            sayi2 = Convert.ToByte(textBox2.Text);
            char islem;
            Convert.ToString(textBox3.Text);
            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    label4.Text = sonuc.ToString();
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    label4.Text = sonuc.ToString();
                    break;
            }
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

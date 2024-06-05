using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler_tekrar
{
    public partial class Form1 : Form
    {
        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text.ToLower();

            int sayac = 0;

            for (int i = 0; i < metin.Length; i++)
            {
                for (int j = 0; j < sesliHarfler.Length; j++)
                {
                    if (metin[i] == sesliHarfler[j])                                 
                    {
                        sayac++;
                        break;
                    }
                }
            }
            label1.Text = "Metindeki sesli harf sayısı: " + sayac;
        }
    }
}

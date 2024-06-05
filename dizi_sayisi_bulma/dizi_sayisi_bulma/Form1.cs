using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizi_sayisi_bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] sesliHarfler = { 'a', 'e', 'u', 'ü', 'ş', 'o', 'ö', 's' };
        private void button1_Click(object sender, EventArgs e)
        {
            //METİN GİRİŞİNİ AL
            string metin = textBox1.Text.ToLower();
            //harf büyüklüğünü almadan önce metni küçük harfe dönüşütür
            int sayac = 0;
            //metnin her harfini kontrol eder
            for (int i = 0; i < metin.Length; i++)
            {
                //kotrol ettiği harfleri sesli olup olmadığına bakar
                for (int j = 0; j < sesliHarfler.Length; j++)
                {
                    if (metin[i] == sesliHarfler[j])
                    {
                        sayac++;
                        break;
                    }
                }
            }
            label1.Text = "Metindeki sesli harfler: " + sayac;
        }
    }
}

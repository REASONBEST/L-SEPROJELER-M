using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maaşuygulamasıi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index = 0;
        string[] personeller;
        int[] maaslar;

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            bool bulundu = false;
            for (int i = 0; i < personeller.Length; i++)
            {
                if (aranan == personeller[i])
                {
                    bulundu = true;
                    listBox1.SelectedIndex = i;
                    break;
                }
            }
            if (bulundu)
            {
                MessageBox.Show("Personel Bulundu");
            }
            else
            {
                MessageBox.Show("Personel Bulunamadı");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            personeller = new String[] { "HAZAL", "MİRAY", "DENİZ", "ARDA", "EMO", "ALPER", "UFKU", "İSO" };
            maaslar = new int[] { 20000, 3000, 25000, 19000, 20000, 24000, 100000, 20000 };
            for (int i = 0; i < personeller.Length; i++)
            {
                listBox1.Items.Add(personeller[i] + "\t" + maaslar[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dusuk = maaslar[0];
            for ( int i = 0; i < maaslar.Length; i++)
            {
                if (dusuk > maaslar[i])
                {
                    dusuk = maaslar[i];
                }
            }
            label1.Text = "En Düşük Maaş Alan Personel : " + dusuk;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int yüksek = maaslar[0];
            int yüksekIndex = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (yüksek < maaslar[i])
                {
                    yüksek = maaslar[i];
                    yüksekIndex = i;
                }
            }
            label1.Text = "EN YÜKSEK MAAS ALAN: " + personeller[yüksekIndex];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "TOPLAM PERSONEL SAYISI : " + personeller.Length;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (maaslar[i] < 20000)
                {
                    listBox1.Items.Add(personeller[i] + " = " + maaslar[i]);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (maaslar[i] < 50000 && maaslar[i] > 70000)
                {
                    sayac++;
                }
            }
            label1.Text = "50.000₺-70.000₺ arasında alanların olanların sayısı: " + sayac;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                toplam += maaslar[i];
            }
            label1.Text = "Toplam Ödenen Maaş Tutarı: " + toplam;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            maaslar[2] += 500;
            for (int i= 0; i < personeller.Length; i++)
            {
                listBox1.Items.Add(personeller[i] + "\t" + maaslar[i]);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personeller[6]);
        }
    }
}

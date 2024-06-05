using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziözellikleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 5, 8, 16, 18, 6 };
            int length = sayilar.Length;
            label1.Text = "Dizi uzunluğu: " + length;
            int rank = sayilar.Rank;
            label2.Text = "Dizi boyutu: " + rank;
            int max = sayilar.Max();
            label3.Text = "Dizideki en büyük değer: " + max;
            int min = sayilar.Min();
            label4.Text = "Dizideki en küçük değer: " + min;
            int sum = sayilar.Sum();
            label5.Text = "Dizideki toplam: " + sum;
            double average = sayilar.Average();
            label6.Text = "Dizideki sayıların ortalaması: " + average;
            int first = sayilar.First();
            label7.Text = "Dizinin ilk elemanı: " + first;
            int last = sayilar.Last();
            label8.Text = "Dizinin son elemanı: " + last;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        int skor = 100;
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = skor.ToString();
            button1.Enabled = true;
            Random random = new Random();
            sayi = random.Next(101);
            MessageBox.Show("Aklımdan bir sayı tuttum");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(textBox1.Text);
            if (tahmin < sayi)
            {
                MessageBox.Show("Yukarı");
                skor = skor - 10;
            }
            else if (tahmin > sayi)
            {
                MessageBox.Show("Aşağı");
                skor = skor - 10;
            }
            else
            {
                MessageBox.Show("TEBRİKLER KAZANDINIZ!");
            }
            if (skor == 0)
            {
                MessageBox.Show("KAYBETTİN!");
                button1.Enabled = false;
            }
            label1.Text = skor.ToString();
            textBox1.Clear();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınavsorusu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            listBox1.Items.Add(ad);
            string soyad = textBox2.Text;
            listBox2.Items.Add(soyad);
            int not1, not2, ort;
            not1 = Convert.ToInt32(textBox3.Text);
            not2 = Convert.ToInt32(textBox4.Text);
            listBox3.Items.Add(not1);
            listBox4.Items.Add(not2);
            ort = (not1 + not2) / 2;
            listBox5.Items.Add(ort);
            if (ort >= 50)
            {
                listBox6.Items.Add("Geçti");
            }
            else if (ort < 50)
            {
                listBox6.Items.Add("Kaldı");
            }
            else
            {
                MessageBox.Show("değerleri kontrol et");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}

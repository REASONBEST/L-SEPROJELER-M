using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForUyg._2
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

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int sayac = 0;
            int baslangicDegeri = Convert.ToInt32(textBox1.Text);
            int bitisdeDegeri = Convert.ToInt32(textBox2.Text);
            for ( i = baslangicDegeri; i < bitisdeDegeri; i++)
            {
                if (i%3 == 0 && i%5 == 0)
                {
                    listBox1.Items.Add(i.ToString());
                    sayac++;
                }
            }
            MessageBox.Show("Hem 3'e hem 5'e Bölünen sayı adedi: " + sayac + " Tenedir");
            }
        }
    }


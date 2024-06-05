using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basbitis
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            int sayac = 0;
            for (i = baslangic; i < bitis; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add(i.ToString());
                    sayac++;
                }
            }
            MessageBox.Show("3e ve 5e bölünen sayı " + sayac + " tanedir.");
        }
    }
}

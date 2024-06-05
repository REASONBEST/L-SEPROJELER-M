using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foruyg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int sayac = 0;
            int baslangicdegeri = Convert.ToInt32(textBox1.Text);
            int bitisdegeri = Convert.ToInt32(textBox2.Text);
            for (i = baslangicdegeri; i < bitisdegeri; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add(i.ToString());
                    sayac++;
                }
            }
            MessageBox.Show("Hem 3'e hem 5'e bölünen sayı adedi: " + sayac + "tanedir");
        }
    }
}

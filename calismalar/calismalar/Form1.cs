using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calismalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            do
            {
                sayi1++;
                if (sayi1 % 3 == 0 && sayi1 % 5 == 0)
                {
                    listBox1.Items.Add(sayi1);
                }
                if (sayi1 % 7 == 0)
                    listBox2.Items.Add(sayi1);
                if (sayi1 % 3 == 0 && sayi1 % 5 == 0 && sayi1 % 7 == 0)
                    listBox3.Items.Add(sayi1);
            } while (sayi1 < sayi2);

        }
    }
}


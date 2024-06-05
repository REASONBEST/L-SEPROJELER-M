using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizirandomsayıüret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] dizikaynak = new int[100];
        int[] dizikopya = new int[100];
        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            for (int i = 0; i < dizikaynak.Length; i++)
            {
                dizikaynak[i] = rastgele.Next(0, 101);
            }
            for (int i = 0; i <dizikopya.Length; i++)
            {
                listBox1.Items.Add(dizikaynak[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<dizikopya.Length;i++)
            {
                dizikopya[i] = dizikaynak[i];
            }
            for (int i = 0; i <dizikopya.Length; i++)
            {
                listBox2.Items.Add(dizikopya[i]);
            }
        }
    }
}

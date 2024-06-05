using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler3e5eboolunenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayi = { 15, 20, 33, 95, 32, 27, 90 };
            for (int i = 0; i < sayi.Length; i++) 
            {
                if (sayi[i] % 5 == 0 && sayi[i] % 3 == 0)
                {
                    listBox1.Items.Add(sayi[i].ToString());
                }
            }
        }
    }
}

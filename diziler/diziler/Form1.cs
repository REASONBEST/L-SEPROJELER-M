using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i <= sayilar.Length;i++)
            {
                MessageBox.Show(sayilar[i].ToString());
            }
        }
    }
}

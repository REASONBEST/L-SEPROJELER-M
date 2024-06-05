using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizi_forinch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dizi = new string[5];
            dizi[0] = "Buse";
            dizi[1] = "Evin";
            dizi[2] = "Deniz";
            dizi[3] = "Alper";
            dizi[4] = "Emirhan";

            foreach (string eleman in dizi)
            {
                listBox1.Items.Add(eleman);
            }

        }
    }
}

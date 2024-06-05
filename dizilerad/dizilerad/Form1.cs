using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizilerad
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
            string[] ogrenciler = new string[10];
            
                ogrenciler[0] = "Miray";
                ogrenciler[1] = "Hazal";
                ogrenciler[2] = "Nisa";
                ogrenciler[3] = "Eylül";
                ogrenciler[4] = "Deniz";
                ogrenciler[5] = "Evin Hoca";
                ogrenciler[6] = "Arda";
                ogrenciler[7] = "Ali";
                ogrenciler[8] = "Emirhan";
                ogrenciler[9] = "Evin Hoca";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                listBox1.Items.Add(ogrenciler[i]);
            }
        }
    }
}

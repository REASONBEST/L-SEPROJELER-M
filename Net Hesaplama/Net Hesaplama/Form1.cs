using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double turkceDogru, matDogru;
                double turkceYanlis, matYanlis;
                double turkceNet, matNet;
                turkceDogru = Convert.ToDouble(textBox1.Text);
                turkceYanlis = Convert.ToDouble(textBox2.Text);
                turkceNet = (turkceDogru - (turkceYanlis / 4));
                textBox3.Text = turkceNet.ToString();
                matDogru = Convert.ToDouble(textBox4.Text);
                matYanlis = Convert.ToDouble(textBox4.Text);
                matNet = (matDogru - (matYanlis / 5));
                textBox6.Text = matNet.ToString();
            }
        }
    }
}

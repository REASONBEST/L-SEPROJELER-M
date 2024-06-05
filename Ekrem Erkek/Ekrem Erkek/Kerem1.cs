using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekrem_Erkek
{
    public partial class Kerem1 : Form
    {
        public Kerem1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToByte(textBox1.Text);
            double kilo = Convert.ToByte(textBox2.Text);
            double vki = kilo / (boy * boy);
            MessageBox.Show("Vücut kitle Endeksiniz: " + vki);
        }
    



        private void Kerem1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

    


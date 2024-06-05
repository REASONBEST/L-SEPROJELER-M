using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayList_Caount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList sehirler = new ArrayList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList sehirler = new ArrayList();

            foreach (var i in sehirler)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList sehirler = new ArrayList();

            for (int i = 0; i < sehirler.Count; i++)
            {

            }
        }
    }
}

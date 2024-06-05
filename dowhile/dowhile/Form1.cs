using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dowhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while(i<7)
            {
                i++;
                if(i==5)
                {
                    MessageBox.Show("Continue");
                    continue;
                }
                MessageBox.Show("i: " + i);
                if(i==6)
                {
                    MessageBox.Show("Break");
                    break;
                }
            }
        }
    }
}

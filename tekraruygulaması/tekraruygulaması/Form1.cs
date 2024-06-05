using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekraruygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] dizeler = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60};
            for (int i = 0; i < dizeler.Length; i++)
            {
                if (dizeler[i] % 3 == 0 && dizeler[i] % 5 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}

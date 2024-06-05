using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indexrenchatasiii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] dizi = { 1, 2, 3 };
                int eleman = dizi[5];
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Hata OLUŞTU",ex.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}

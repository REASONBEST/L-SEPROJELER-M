using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyaBulunamadiHatasi
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
                string filePath = "hatali_dosya.txt";
                System.IO.File.OpenRead(filePath);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("Dosyanız bulunmadı. " + ex.Message);
            }
        }
    }
}

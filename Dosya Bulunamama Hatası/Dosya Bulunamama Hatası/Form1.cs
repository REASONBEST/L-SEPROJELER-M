using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosya_Bulunamama_Hatası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "Manav";
            if (System.IO.File.Exists(filePath))
            {
                MessageBox.Show("Dosyanız Bulundu.");
            }
            else 
            try
            {
                string filePath = "hatali_dosya.txt";
                System.IO.File.OpenRead(filePath);
            }
            catch (System.IO.FileNotFoundException ex) //dosya bulunamadı hatası
            {
                MessageBox.Show("Dosyanız Bulunamadı. " + ex.Message);
            }
        }
    }
}

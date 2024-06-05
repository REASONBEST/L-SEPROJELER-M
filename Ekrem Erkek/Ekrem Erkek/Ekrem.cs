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
    public partial class Ekrem : Form
    {
        public Ekrem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            double boy = Convert.ToDouble(textBox1.Text);
            double kilo = Convert.ToDouble(textBox2.Text);
            double vki = kilo / (boy * boy);
            MessageBox.Show("vücüt kitle endeksiniz" + vki);
            if (vki < 17) 
                MessageBox.Show("Vücut kitle indeksiniz kötü.");
            if (vki <= 25)
                MessageBox.Show("Vücut kitle indeksiniz iyi.");
            else
            if (vki >= 26)
                MessageBox.Show("Vücüt kitle indeksiniz fazla.");
        }

             
        }

    }


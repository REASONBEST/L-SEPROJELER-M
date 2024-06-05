using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayisiralama
{
    public partial class Form1 : Form
    {
        static int[] sayilar = new int[16];
        static int sayac = 0;
        static bool basladimi = false;
        static int saniye = 0, dakika = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Sırala";
            //sayı tutma ---------------------------------------------
            //int[] sayilar = new int[16];
            for (int i = 0; i < 16; i++) sayilar[i] = 0;
            Random r = new Random();
            bool durum = false;//yok
            int sayac = 0;
            do
            {
                int s = r.Next(1, 16);
                for (int i = 0; i < 15; i++)
                {
                    if (s == sayilar[i])
                    {
                        durum = true;//var
                        break;
                    }
                }

                if (durum == false)
                {
                    sayilar[sayac] = s;
                    sayac++;
                }
                else
                    durum = false;

            } while (sayac < 15);

            // for (int i = 0; i < 15; i++) label1.Text += " " + sayilar[i];


            //button ekleme ---------------------------
            this.Size = new Size(220, 275);
            int h = 0;
            for (int i = 0; i < 15; i++)
            {
                Button buton = new Button();
                buton.Name = "b" + i.ToString();
                buton.Size = new Size(50, 50);
                if (i % 4 == 0) h++;
                buton.Text = sayilar[i].ToString();
                buton.Font = new Font("arial", 14);
                buton.Location = new Point((i % 4) * 50, (h - 1) * 50);//x,y
                buton.Click += islem;//metod bağlandı
                this.Controls.Add(buton);
            }

        }
    }
}

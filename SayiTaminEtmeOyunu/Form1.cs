using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTaminEtmeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tutulanSayi, sayac;

        private void tahmin_et_buton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                sonuc_text.Text = "Sayı giriniz.";
            }
            else
            {
                int girilenSayi = int.Parse(textBox1.Text);

                if (girilenSayi < tutulanSayi)
                {
                    sonuc_text.Text = "Yukarı";
                    sayac--;
                }
                else if (girilenSayi > tutulanSayi)
                {
                    sonuc_text.Text = "Aşağı";
                    sayac--;
                }
                else
                {
                    sonuc_text.Text = "Tebrikler. Kazandın.";
                    tahmin_et_buton.Enabled = false;
                }
            }
            sayac_text.Text = sayac.ToString();

            if (sayac == 0)
            {
                tahmin_et_buton.Enabled = false;
                sonuc_text.Text = "Maalesef bilemedin şansını tekrar dene! Tutulan Sayı:" + tutulanSayi;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void basla_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            tutulanSayi = rastgele.Next(1, 100);

            sayac = 5;
            sayac_text.Text = sayac.ToString();
            sonuc_text.Text = "";
            textBox1.Text = "";

           tahmin_et_buton.Enabled = true;
        }
    }
}

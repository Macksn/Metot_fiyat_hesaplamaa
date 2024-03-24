using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace metot_fiyat_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int toplam(int cay, int tost, int sımıt, int kahve)
        {
            int sonuc = 0;
            cay = 1 * cay;
            tost = 5 * tost;
            sımıt = 1 * sımıt;
            kahve = 5 * kahve;

            sonuc = cay + tost + sımıt + kahve;
            label6.Text = sonuc.ToString();
            return (sonuc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cay, tost, sımıt, kahve;
            cay = Convert.ToInt16(textBox1.Text);
            tost = Convert.ToInt16(textBox2.Text);
            sımıt = Convert.ToInt16(textBox3.Text);
            kahve = Convert.ToInt16(textBox4.Text);
            label6.Text = toplam(cay, tost, sımıt, kahve).ToString();
        }
     
    }
}

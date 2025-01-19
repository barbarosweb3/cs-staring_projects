using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_Ornek_Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();

            rb.renk = "Yeşil";
            rb.hiz = 200;
            rb.motor = 1300;
            rb.fiyat = 50000;
            rb.durum = 'y';
            rb.YIL = 2024;
            rb.MARKASI = "mercedes";
            rb.plaka = "06 EUU 862";
            rb.sahip = "Barbaros Emre Alagöz";
            rb.muayene = 2026;

            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKASI;
            label8.Text = rb.plaka;
            label9.Text = rb.sahip;
            label10.Text = rb.muayene.ToString();

            pictureBox1.BackColor = Color.CadetBlue;
        }
    }
}

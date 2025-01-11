using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_Ornek_Kapsulleme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();

            rb.renk = "Mavi";
            rb.hiz = 160;
            rb.motor = 1600;
            rb.fiyat = 40000;
            rb.durum = 'i';
            rb.YIL = 2019;
            rb.MARKASI = "renault";

            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKASI;

            pictureBox1.BackColor = Color.SeaGreen;
        }
    }
}

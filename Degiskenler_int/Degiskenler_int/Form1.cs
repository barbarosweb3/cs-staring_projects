using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kısa_kenar, uzun_kenar, alan, çevre;
            kısa_kenar = 10;
            uzun_kenar = 20;
            alan = uzun_kenar * kısa_kenar;
            çevre = 2 * (uzun_kenar + kısa_kenar);
            label1.Text = "Alan: " + alan + " Çevre: " + çevre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3, ortalama;
            sinav1 = Convert.ToInt32(maskedTextBox1.Text);
            sinav2 = Convert.ToInt32(maskedTextBox2.Text);
            sinav3 = Convert.ToInt32(maskedTextBox3.Text);
            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            label5.Text = ortalama.ToString();

        }
    }
}

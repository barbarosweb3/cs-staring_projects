using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Okul_Tarzı_Basit_Sistem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2, proje;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            s1 = Convert.ToInt32(textBox3.Text);
            s2 = Convert.ToInt32(textBox4.Text);
            proje = Convert.ToInt32(textBox5.Text);
            ortalama = (s1 + s2 + proje) / 3;
            listBox1.Items.Add("Öğrenci Adı: " + ad + Environment.NewLine + "Soyadı: " + soyad + Environment.NewLine + "1. Sınav Notu: " + s1 + Environment.NewLine + "2.Sınav Notu: " + s2 + Environment.NewLine + "Ortalama: " + ortalama);
        }
    }
}

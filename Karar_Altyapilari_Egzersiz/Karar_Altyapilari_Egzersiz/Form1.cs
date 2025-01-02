using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Altyapilari_Egzersiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int s1, s2, ort;
            //s1 = Convert.ToInt32(textBox1.Text);
            //s2 = Convert.ToInt32(textBox2.Text);
            //ort = (s1 + s2) / 2;
            //label3.Text = ort.ToString();

            //string sonuc;
            //if (ort >= 50)
            //    sonuc = "Sınıfı geçtin!";
            //else
            //    sonuc = "Sınıfta kaldın!";
            //label4.Text = sonuc;

            double s1, s2, proje, ort;
            string durum;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text);
            ort = (s1 + s2 + proje) / 3;

            if (ort >= 50)
            {
                durum = "Geçti.";
            }
            else
            {
                durum = "Kaldı.";
            }

            textBox4.Text = ort.ToString("0.00") + " / " + durum;

        }
    }
}

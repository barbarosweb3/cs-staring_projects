using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Return_Method_Ornekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //int Kup(int sayi)
        //{
        //    int sonuc = sayi * sayi * sayi;
        //    return (sonuc);
        //}

        int Toplam(int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //int s = Convert.ToInt32(textBox1.Text);
            //label1.Text = Kup(s).ToString();
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuc = Toplam(sayi1, sayi2);
            label3.Text = sonuc.ToString();
        }
    }
}

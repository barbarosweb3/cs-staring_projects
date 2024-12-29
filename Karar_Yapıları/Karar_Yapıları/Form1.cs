using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapıları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if-else komutları
            //int sayi = Convert.ToInt16(textBox1.Text);
            //if (sayi == 5)
            //{
            //    label1.Text = "Doğru";
            //}
            //else
            //{
            //    label1.Text = "Yanlış";
            //}
            // farklı örneklerle öğrenelim
            //int sayi = Convert.ToInt16(textBox1.Text);
            //if (sayi % 2 == 0) 
            //{
            //    label1.Text = "Bu bir çift sayıdır.";
            //}
            //else
            //{
            //    label1.Text = "Bu bir tek sayıdır.";
            //}
            // yeni bir örnek
            //int sayi = Convert.ToInt16(textBox1.Text);
            //if (sayi % 2 == 0 && sayi >= 10) 
            //{
            //    label1.Text = "Ondan büyük ve çift";
            //}
            //else 
            //{
            //    label1.Text = "Ondan büyük değil ya da çift değil";
            //}
            // Yeni Örnek:
            int sayi = Convert.ToInt16(textBox1.Text);
            if (sayi % 2 == 0 || sayi >= 10)
            {
                label1.Text = "Ondan büyük veya çift";
            }
            else
            {
                label1.Text = "Ondan büyük değil veya çift değil";
            }
        }
    }
}

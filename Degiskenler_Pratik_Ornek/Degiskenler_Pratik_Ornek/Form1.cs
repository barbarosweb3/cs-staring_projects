using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Pratik_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, çarpım, fark, bölüm;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            çarpım = sayi1 * sayi2;
            bölüm = sayi1 / sayi2;
            MessageBox.Show("Toplam: " + toplam + "\n" + "Fark:" + fark + "\n" + "Çarp: " + çarpım + "\n" + "Bölüm: " + bölüm);
        }
    }
}

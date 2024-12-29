using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_Proje_3_Urun_Fiyat_KDV_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int urun_fiyati, eight_kdv, eighteen_kdv;
            urun_fiyati = Convert.ToInt16(textBox1.Text);
            eight_kdv = (int)((urun_fiyati * 0.08) + urun_fiyati);
            eighteen_kdv = (int)((urun_fiyati * 0.18) + urun_fiyati);
            listBox1.Items.Add("Ürün fiyatı: " + urun_fiyati + " Ürün %8 KDV'li fiyat: " + eight_kdv + " Ürün %18 KDV'li fiyat: " + eighteen_kdv);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kişiler = { "Ali", "Ahmet", "Mehmet", "Mesut", "Pınar", "Berna" };
            //foreach(string k in kişiler)
            //{
            //    listBox1.Items.Add(k);
            //}

            int toplam = 0;
            int[] sinavlar = {70, 65, 85, 100, 90, 60, 95, 96,75,50 };
            foreach (int i in sinavlar)
            {
                listBox1.Items.Add(i);
                toplam = toplam + i;
            }
            label1.Text = toplam.ToString();

            int ortalama = toplam / sinavlar.Length;
            label2.Text = ortalama.ToString();
        }
    }
}

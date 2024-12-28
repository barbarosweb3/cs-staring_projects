using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ad, soyad, yaş, meslek, cinsiyet;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            yaş = maskedTextBox1.Text;
            meslek = comboBox1.Text;
            cinsiyet = comboBox2.Text;
            listBox1.Items.Add(ad + " " + soyad + " " + yaş  + " " + meslek + " " + cinsiyet);

        }
    }
}

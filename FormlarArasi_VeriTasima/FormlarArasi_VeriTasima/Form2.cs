using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasi_VeriTasima
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string ad, soyad, meslek;
        private void Form2_Load(object sender, EventArgs e)
        {
            //label1.Text = mesaj;
            //label2.Text = mesaj2;

            comboBox1.Items.Add(ad);
            comboBox1.Items.Add(soyad);
            comboBox1.Items.Add(meslek);


        }
    }
}

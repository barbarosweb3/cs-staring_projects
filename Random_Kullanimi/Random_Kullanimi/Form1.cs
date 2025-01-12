using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //int sayi;
            //sayi = rnd.Next(1, 10);
            //label1.Text = sayi.ToString();

            Random rnd = new Random();
            int s1, s2, s3;
            s1 = rnd.Next(1,5);
            s2 = rnd.Next(1,5);
            s3 = rnd.Next(1,5);
            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
        }
    }
}

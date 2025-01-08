using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "Ali", "Ahmet", "Mehmet", "Aslı", "Hakan", "Ayşe", "Demet" };
            //label1.Text = kisiler[4];

            //int[] sayilar = { 4, 7, 5, 6, 9, 8, 2, 3 };
            //label1.Text = Convert.ToString(sayilar[5]);

            //double[] sayilar = { 0.3, 1.4, 2.5, 3.6, 7.9 };
            //label1.Text = sayilar[4].ToString();

            char[] chars = { 'a', 'b', 'c' };
            label1.Text = chars[0].ToString();
        }
    }
}

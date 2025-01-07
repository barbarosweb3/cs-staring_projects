using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            //if (sayac == 50)
            //{
            //    timer1.Stop();
            //    this.BackColor = Color.PeachPuff;
            //}

            //if (sayac == 15)
            //{
            //    this.BackColor = Color.PeachPuff;
            //}
            //if (sayac == 30)
            //{
            //    this.BackColor = Color.Green;
            //    timer1.Stop();
            //}

            if (sayac <= 30)
            {
                this.BackColor = Color.Red;
            }
            else if (sayac <= 40)
            {
                this.BackColor = Color.Yellow;
            }
            else if (sayac <= 70)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                sayac = 0;
            }
        }
    }
}

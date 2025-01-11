using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace MenuStrip_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Barbaros Alagöz tarafından yapıldı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/XJMuhwVlca4?si=0M4vRyqaMVJV7T3-");
            label1.Text = "Mad Max";
        }

        private void pSILoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/CZzW6_hR068?si=Lf6BJgO9cfqufWM5");
            label1.Text = "Not: Seni Seviyorum";
        }

        private void aynıYıldızınAltındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/aQnlngjZG48?si=dotNjdNiN9tk69sd");
        }

        private void conjuringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/k10ETZ41q5o?si=ww70bo4OUvDNEQR1");
        }

        private void uzayYolcularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/7BWWWQzTpNU?si=bJR6ydJwqXx2WNUw");
        }
    }
}

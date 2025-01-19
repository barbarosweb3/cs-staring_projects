using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void btnKategoriİslemleri_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnUrunİslemleri_Click(object sender, EventArgs e)
        {
            FrmUrun frm = new FrmUrun();
            frm.Show();
        }

        private void btnIstatistikler_Click(object sender, EventArgs e)
        {
            FrmIstatistik frm = new FrmIstatistik();
            frm.Show();
        }
    }
}

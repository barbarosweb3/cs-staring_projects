using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using EntityLayer;
using DataAccessLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            LogicPersonel.LLPersonelEkle(new EntityPersonel
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Sehir = txtSehir.Text,
                Maas = short.Parse(txtMaas.Text),
                Meslek = txtGorev.Text
            });
            MessageBox.Show("Personel Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            LogicPersonel.LLPersonelSil(int.Parse(txtId.Text));
            MessageBox.Show("Personel Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            LogicPersonel.LLPersonelGuncelle(new EntityPersonel
            {
                Id = int.Parse(txtId.Text),
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Sehir = txtSehir.Text,
                Maas = short.Parse(txtMaas.Text),
                Meslek = txtGorev.Text
            });
            MessageBox.Show("Personel Eklendi");
        }
    }
}

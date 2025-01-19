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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FİYAT,
                                            x.TBLKATEGORI.AD,
                                            x.DURUM
                                        }).ToList();
                                        
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = txtUrunAdi.Text;
            t.MARKA = txtMarka.Text;
            t.STOK = short.Parse(txtStokSayisi.Text);
            t.KATEGORI = int.Parse(cmbKategori.SelectedValue.ToString());
            t.FİYAT = decimal.Parse(txtFiyat.Text);
            t.DURUM = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Seçili ürünü siler
            int x = Convert.ToInt32(txtId.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Seçili ürünü günceller
            int x = Convert.ToInt32(txtId.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD = txtUrunAdi.Text;
            urun.MARKA = txtMarka.Text;
            urun.STOK = short.Parse(txtStokSayisi.Text);
            urun.KATEGORI = int.Parse(cmbKategori.Text);
            urun.FİYAT = decimal.Parse(txtFiyat.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //Textboxları temizler
            txtId.Text = "";
            txtUrunAdi.Text = "";
            txtMarka.Text = "";
            txtStokSayisi.Text = "";
            cmbKategori.Text = "";
            txtFiyat.Text = "";
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORI
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();
            cmbKategori.ValueMember = "ID";
            cmbKategori.DisplayMember = "AD";
            cmbKategori.DataSource = kategoriler;
        }
    }
}

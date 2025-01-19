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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            lblKategoriSayisi.Text = db.TBLKATEGORI.Count().ToString();
            lblUrunSayisi.Text = db.TBLURUN.Count().ToString();
            lblAktifMusteriSayisi.Text = db.TBLMUSTERI.Where(x => x.DURUM == true).Count().ToString();
            lblPasifMusteriSayisi.Text = db.TBLMUSTERI.Where(x => x.DURUM == false).Count().ToString();
            lblBeyazEsyaSayisi.Text = db.TBLURUN.Where(x => x.KATEGORI == 1).Count().ToString();
            lblToplamStok.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            lblEnYuksekFiyatlıUrun.Text = db.TBLURUN.OrderByDescending(x => x.FİYAT).Select(y => y.URUNAD).FirstOrDefault();
            lblEnDusukFiyatliUrun.Text = db.TBLURUN.OrderBy(x => x.FİYAT).Select(y => y.URUNAD).FirstOrDefault();
            lblSehirSayisi.Text = db.TBLMUSTERI.Select(x => x.SEHIR).Distinct().Count().ToString();
            lblKasaTutar.Text = db.TBLSATIS.Sum(x => x.FIYAT).ToString() + " TL";
            lblEnFazlaUrunluMarka.Text = db.TBLURUN.GroupBy(x => x.MARKA).OrderByDescending(y => y.Count()).Select(z => z.Key).FirstOrDefault();
            lblEnFazlaStokluUrun.Text = db.TBLURUN.OrderByDescending(x => x.STOK).Select(y => y.URUNAD).FirstOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Odeux\\MSSQLSERVER01;Initial Catalog=PersonelVeriTabani;Integrated Security=True;TrustServerCertificate=True");

        void temizle()
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            cmbSehir.Text = "";
            mskMaas.Text = "";
            txtMeslek.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TxtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek, PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery(); // insert, update, delete işlemlerinde kullanılır.
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True"; // burada radioButton'ların durumuna göre label8'i değiştirir.
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False"; // burada radioButton'ların durumuna göre label8'i değiştirir.
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; // seçilen hücrenin satır indexini alır.

            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); // seçilen satırın 0. hücresini alır.
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString(); // seçilen satırın 1. hücresini alır.
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString(); // seçilen satırın 2. hücresini alır.
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString(); // seçilen satırın 3. hücresini alır.
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString(); // seçilen satırın 4. hücresini alır.
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString(); // seçilen satırın 5. hücresini alır.
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString(); // seçilen satırın 6. hücresini alır.
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true; // burada label8 değiştiğinde radioButton'ların durumunu değiştirir.
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true; // burada label8 değiştiğinde radioButton'ların durumunu değiştirir.
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_Personel where Perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", TxtId.Text);
            komutsil.ExecuteNonQuery(); // insert, update, delete işlemlerinde kullanılır.
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("update Tbl_Personel set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerMeslek=@a5,PerDurum=@a6 where Perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", TxtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", TxtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", cmbSehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", mskMaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", txtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a6", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a7", TxtId.Text);
            komutguncelle.ExecuteNonQuery(); // insert, update, delete işlemlerinde kullanılır.
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik fr = new FrmIstatistik();
            fr.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frg = new FrmGrafikler();
            frg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRaporlar frp = new FrmRaporlar();
            frp.Show();
        }
    }
}

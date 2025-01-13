using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kitaplik_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\barba\\OneDrive\\Masaüstü\\Kitaplık.mdb");

        void Listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Kitaplar", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        string durum = "";

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kitaplar (KitapAd,Yazar,Tur, Sayfa,Durum) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKitapYazar.Text);
            komut.Parameters.AddWithValue("@p3", cmbTur.Text);
            komut.Parameters.AddWithValue("@p4", txtKitapSayfa.Text);
            komut.Parameters.AddWithValue("@p5", durum);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtKitapId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtKitapYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtKitapSayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("Delete From Kitaplar where KitapId=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapId.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("Update Kitaplar set KitapAd=@p1,Yazar=@p2,Tur=@p3,Sayfa=@p4,Durum=@p5 where KitapId=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKitapYazar.Text);
            komut.Parameters.AddWithValue("@p3", cmbTur.Text);
            komut.Parameters.AddWithValue("@p4", txtKitapSayfa.Text);
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", txtKitapId.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from Kitaplar where KitapAd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapBul.Text);
            OleDbDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from Kitaplar where KitapAd like '%" + txtKitapBul.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

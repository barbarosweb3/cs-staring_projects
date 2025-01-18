using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Bonus_Proje1
{
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Odeux\MSSQLSERVER01;Initial Catalog=BonusOkul;Integrated Security=True;TrustServerCertificate=True");
        public void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLKULUPLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmKulup_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLKULUPLER (KULUPAD) values (@p1)", baglanti);
            cmd.Parameters.AddWithValue("@p1", txtKulupAd.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
            try
            {
                txtKulupAd.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKulupId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKulupAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from TBLKULUPLER where KULUPID=@p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", txtKulupId.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update TBLKULUPLER set KULUPAD=@p1 where KULUPID=@p2", baglanti);
            cmd.Parameters.AddWithValue("@p1", txtKulupAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtKulupId.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }
    }
}

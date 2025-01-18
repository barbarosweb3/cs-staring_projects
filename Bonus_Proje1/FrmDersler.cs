using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Bonus_Proje1
{
    [Serializable]
    public partial class FrmDersler : Form
    {
        private DataSet1TableAdapters.TBLDERSLERTableAdapter ds;

        public FrmDersler()
        {
            InitializeComponent();
            ds = new DataSet1TableAdapters.TBLDERSLERTableAdapter();
        }

        private void FrmDersler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Fill(new DataSet1.TBLDERSLERDataTable());
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.InsertQuery(txtDersAd.Text);
            dataGridView1.DataSource = ds.Fill(new DataSet1.TBLDERSLERDataTable());
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Fill(new DataSet1.TBLDERSLERDataTable());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.DeleteQuery(byte.Parse(txtDersId.Text));
            dataGridView1.DataSource = ds.Fill(new DataSet1.TBLDERSLERDataTable());
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.UpdateQuery(txtDersAd.Text, byte.Parse(txtDersId.Text));
            dataGridView1.DataSource = ds.Fill(new DataSet1.TBLDERSLERDataTable());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDersId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtDersAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
            }
        }
    }
}
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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Odeux\\MSSQLSERVER01;Initial Catalog=PersonelVeriTabani;Integrated Security=True;TrustServerCertificate=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // Grafik 1
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select PerSehir, count(*) from Tbl_Personel group by PerSehir", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr[0], dr[1]);
            }
            baglanti.Close();

            // Grafik 2
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select PerMeslek, avg(PerMaas) from Tbl_Personel group by PerMeslek", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();

        }
    }
}

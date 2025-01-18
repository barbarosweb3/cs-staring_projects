namespace Proje_Ornekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt16(textBox1.Text);
                int sayi2 = Convert.ToInt16(textBox2.Text);
                int toplam = sayi1 + sayi2;
                MessageBox.Show("Toplam: " + toplam);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen deðerlerinizi kontrol edin!");
            }
        }
    }
}

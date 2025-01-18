namespace Örnekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hata yakalama
            //try
            //{
            //    int s1, s2, sonuc;
            //    s1 = Convert.ToInt32(textBox1.Text);
            //    s2 = Convert.ToInt32(textBox2.Text);
            //    sonuc = s1 * s2;
            //    label1.Text = sonuc.ToString();
            //}
            //catch (Exception hata)
            //{

            //    MessageBox.Show("Hata: " + hata.Message);
            //}

            // Finally bloğu
            try
            {
                int s1, s2, sonuc;
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                sonuc = s1 * s2;
                label1.Text = sonuc.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata var burası çalıştı");
            }
            finally
            {
                MessageBox.Show("Finally bloğu çalıştı");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Return_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Carpim(int s1, int s2, int s3) 
        {
            int s4 = s1 * s2 * s3;
            return s4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = Toplam(4, 6).ToString();
            label1.Text = Carpim(3,4,7).ToString();
        }
    }
}

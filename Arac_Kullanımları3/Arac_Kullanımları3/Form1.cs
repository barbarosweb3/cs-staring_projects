using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanımları3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(maskedTextBox1.Text + " " +  maskedTextBox2.Text + " " + maskedTextBox3.Text + " " + maskedTextBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = maskedTextBox5.Text;
            label6.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            label8.Text = comboBox1.Text;
            label9.Text = dateTimePicker2.Text;
            listBox2.Items.Add(label5.Text + " " + label6.Text + " " + label7.Text + " " + label8.Text + " " + label9.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2;
            s1 = Convert.ToInt16(textBox1.Text);
            s2 = Convert.ToInt16(textBox2.Text);
            string operatör;
            operatör = textBox3.Text.Trim();
            switch (operatör)
            {
                case "+":
                    label5.Text = Convert.ToString(s1 + s2);
                    break;
                case "-":
                    label5.Text = Convert.ToString(s1 - s2);
                    break;
                case "*":
                    label5.Text = Convert.ToString(s1 * s2);
                    break;
                case "/":
                    if (s2 != 0) // Sıfıra bölme kontrolü
                    {
                        label5.Text = Convert.ToString(s1 / s2);
                    }
                    else
                    {
                        label5.Text = "Sıfıra bölünemez!";
                    }
                    break;
                default:
                    label5.Text = "Geçersiz operatör!";
                    break;
            }
        }

            

        }
    }

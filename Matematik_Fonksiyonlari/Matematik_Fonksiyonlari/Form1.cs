﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Fonksiyonlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            //label2.Text = Math.Abs(sayi).ToString();
            //label2.Text = Math.Ceiling(sayi).ToString();
            //label2.Text = Math.Floor(sayi).ToString();
            //label2.Text = Math.Pow(sayi, 2).ToString();
            //label2.Text = Math.Sqrt(sayi).ToString();
            //label2.Text = Math.PI.ToString();
            label2.Text = Math.Cos(sayi).ToString();
        }
    }
}

/*
 * Abs = Mutlak Değer
 * Ceil = Üste Yuvarlama
 * Floor = Alta Yuvarlama
 * Pow = Üs Alma
 * Sqrt = Karekök Alma
 * PI = Pi Sayısı
 * cos = Cosinüs
 */

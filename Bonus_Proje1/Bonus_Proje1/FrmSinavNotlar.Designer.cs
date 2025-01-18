namespace Bonus_Proje1
{
    partial class FrmSinavNotlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinavNotlar));
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label5 = new Label();
            txtSinav1 = new TextBox();
            label4 = new Label();
            txtSinav2 = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSinav3 = new TextBox();
            label6 = new Label();
            txtDurum = new TextBox();
            label7 = new Label();
            txtProje = new TextBox();
            label8 = new Label();
            txtOrtalama = new TextBox();
            pictureBox2 = new PictureBox();
            btnHesapla = new Button();
            pictureBox1 = new PictureBox();
            btnGuncelle = new Button();
            pictureBox3 = new PictureBox();
            btnTemizle = new Button();
            pictureBox4 = new PictureBox();
            btnAra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 297);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1320, 241);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(166, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(316, 28);
            comboBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(65, 163);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 35);
            label5.TabIndex = 70;
            label5.Text = "Sınav2:";
            // 
            // txtSinav1
            // 
            txtSinav1.Location = new Point(166, 136);
            txtSinav1.Name = "txtSinav1";
            txtSinav1.Size = new Size(316, 27);
            txtSinav1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(65, 130);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 35);
            label4.TabIndex = 68;
            label4.Text = "Sınav1:";
            // 
            // txtSinav2
            // 
            txtSinav2.Location = new Point(166, 169);
            txtSinav2.Name = "txtSinav2";
            txtSinav2.Size = new Size(316, 27);
            txtSinav2.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Location = new Point(166, 68);
            txtId.Name = "txtId";
            txtId.Size = new Size(316, 27);
            txtId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(91, 96);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 35);
            label3.TabIndex = 65;
            label3.Text = "Ders:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 67);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 35);
            label2.TabIndex = 64;
            label2.Text = "Öğrenci Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 196);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 35);
            label1.TabIndex = 73;
            label1.Text = "Sınav3:";
            // 
            // txtSinav3
            // 
            txtSinav3.Location = new Point(166, 202);
            txtSinav3.Name = "txtSinav3";
            txtSinav3.Size = new Size(316, 27);
            txtSinav3.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(563, 128);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 35);
            label6.TabIndex = 79;
            label6.Text = "Durum:";
            // 
            // txtDurum
            // 
            txtDurum.Location = new Point(664, 134);
            txtDurum.Name = "txtDurum";
            txtDurum.Size = new Size(316, 27);
            txtDurum.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(536, 95);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(118, 35);
            label7.TabIndex = 77;
            label7.Text = "Ortalama:";
            // 
            // txtProje
            // 
            txtProje.Location = new Point(664, 68);
            txtProje.Name = "txtProje";
            txtProje.Size = new Size(316, 27);
            txtProje.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(582, 67);
            label8.Margin = new Padding(7, 0, 7, 0);
            label8.Name = "label8";
            label8.Size = new Size(72, 35);
            label8.TabIndex = 75;
            label8.Text = "Proje:";
            // 
            // txtOrtalama
            // 
            txtOrtalama.Location = new Point(664, 101);
            txtOrtalama.Name = "txtOrtalama";
            txtOrtalama.Size = new Size(316, 27);
            txtOrtalama.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1040, 67);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 81;
            pictureBox2.TabStop = false;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.FromArgb(42, 54, 80);
            btnHesapla.Cursor = Cursors.Hand;
            btnHesapla.FlatStyle = FlatStyle.Flat;
            btnHesapla.ForeColor = Color.White;
            btnHesapla.Location = new Point(1091, 67);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(241, 35);
            btnHesapla.TabIndex = 80;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1040, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 83;
            pictureBox1.TabStop = false;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(42, 54, 80);
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(1091, 108);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(241, 37);
            btnGuncelle.TabIndex = 82;
            btnGuncelle.Text = "GUNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1040, 150);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 85;
            pictureBox3.TabStop = false;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(42, 54, 80);
            btnTemizle.Cursor = Cursors.Hand;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(1091, 150);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(241, 35);
            btnTemizle.TabIndex = 84;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1040, 191);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 87;
            pictureBox4.TabStop = false;
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.FromArgb(42, 54, 80);
            btnAra.Cursor = Cursors.Hand;
            btnAra.FlatStyle = FlatStyle.Flat;
            btnAra.ForeColor = Color.White;
            btnAra.Location = new Point(1091, 191);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(241, 35);
            btnAra.TabIndex = 86;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // FrmSinavNotlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 54, 80);
            ClientSize = new Size(1356, 550);
            Controls.Add(pictureBox4);
            Controls.Add(btnAra);
            Controls.Add(pictureBox3);
            Controls.Add(btnTemizle);
            Controls.Add(pictureBox1);
            Controls.Add(btnGuncelle);
            Controls.Add(pictureBox2);
            Controls.Add(btnHesapla);
            Controls.Add(label6);
            Controls.Add(txtDurum);
            Controls.Add(label7);
            Controls.Add(txtProje);
            Controls.Add(label8);
            Controls.Add(txtOrtalama);
            Controls.Add(label1);
            Controls.Add(txtSinav3);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(txtSinav1);
            Controls.Add(label4);
            Controls.Add(txtSinav2);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSinavNotlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSinavNotlar";
            Load += FrmSinavNotlar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox txtSinav1;
        private Label label4;
        private TextBox txtSinav2;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSinav3;
        private Label label6;
        private TextBox txtDurum;
        private Label label7;
        private TextBox txtProje;
        private Label label8;
        private TextBox txtOrtalama;
        private PictureBox pictureBox2;
        private Button btnHesapla;
        private PictureBox pictureBox1;
        private Button btnGuncelle;
        private PictureBox pictureBox3;
        private Button btnTemizle;
        private PictureBox pictureBox4;
        private Button btnAra;
    }
}
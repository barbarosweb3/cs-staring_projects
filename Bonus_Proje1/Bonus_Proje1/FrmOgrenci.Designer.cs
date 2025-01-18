namespace Bonus_Proje1
{
    partial class FrmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenci));
            btnAra = new Button();
            txtAra = new TextBox();
            label6 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            label5 = new Label();
            txtSoyad = new TextBox();
            label4 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSil = new Button();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnListele = new Button();
            txtAd = new TextBox();
            txtId = new TextBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.FromArgb(42, 54, 80);
            btnAra.Cursor = Cursors.Hand;
            btnAra.FlatStyle = FlatStyle.Flat;
            btnAra.ForeColor = Color.White;
            btnAra.Location = new Point(464, 605);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(240, 54);
            btnAra.TabIndex = 65;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(93, 619);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(316, 34);
            txtAra.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(816, 620);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 35);
            label6.TabIndex = 63;
            label6.Text = "Cinsiyet:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(983, 623);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 32);
            radioButton2.TabIndex = 62;
            radioButton2.TabStop = true;
            radioButton2.Text = "Erkek";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(916, 623);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 32);
            radioButton1.TabIndex = 61;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kız";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(916, 581);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(316, 36);
            comboBox1.TabIndex = 60;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(816, 582);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 35);
            label5.TabIndex = 59;
            label5.Text = "Kulübü:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(916, 541);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(316, 34);
            txtSoyad.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(824, 542);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 35);
            label4.TabIndex = 57;
            label4.Text = "Soyad:";
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1245, 26);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(48, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 56;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(377, 521);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(81, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 55;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(377, 461);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(81, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 54;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(36, 525);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(81, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 53;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 465);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(42, 54, 80);
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(464, 521);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(240, 54);
            btnSil.TabIndex = 51;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(42, 54, 80);
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(123, 521);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(241, 54);
            btnEkle.TabIndex = 50;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(42, 54, 80);
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(464, 461);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(240, 54);
            btnGuncelle.TabIndex = 49;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.FromArgb(42, 54, 80);
            btnListele.Cursor = Cursors.Hand;
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.ForeColor = Color.White;
            btnListele.Location = new Point(123, 461);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(241, 54);
            btnListele.TabIndex = 48;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(916, 501);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(316, 34);
            txtAd.TabIndex = 47;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(916, 460);
            txtId.Name = "txtId";
            txtId.Size = new Size(316, 34);
            txtId.TabIndex = 46;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1258, 300);
            dataGridView1.TabIndex = 45;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(856, 501);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 35);
            label3.TabIndex = 43;
            label3.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(782, 461);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 35);
            label2.TabIndex = 42;
            label2.Text = "Öğrenci Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(155, 51);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(387, 38);
            label1.TabIndex = 41;
            label1.Text = "ÖĞRENCİ İŞLEMLERİ PANELİ";
            // 
            // FrmOgrenci
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 54, 80);
            ClientSize = new Size(1325, 715);
            Controls.Add(btnAra);
            Controls.Add(txtAra);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(txtSoyad);
            Controls.Add(label4);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnListele);
            Controls.Add(txtAd);
            Controls.Add(txtId);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmOgrenci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmOgrenci";
            Load += FrmOgrenci_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAra;
        private TextBox txtAra;
        private Label label6;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox txtSoyad;
        private Label label4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btnSil;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnListele;
        private TextBox txtAd;
        private TextBox txtId;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
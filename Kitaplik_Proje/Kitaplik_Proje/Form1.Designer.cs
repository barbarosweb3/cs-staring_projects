namespace Kitaplik_Proje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtKitapYazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapSayfa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKitapId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKitapBul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 393);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1094, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Ad:";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(261, 131);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(236, 34);
            this.txtKitapAd.TabIndex = 2;
            // 
            // txtKitapYazar
            // 
            this.txtKitapYazar.Location = new System.Drawing.Point(261, 171);
            this.txtKitapYazar.Name = "txtKitapYazar";
            this.txtKitapYazar.Size = new System.Drawing.Size(236, 34);
            this.txtKitapYazar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazar:";
            // 
            // txtKitapSayfa
            // 
            this.txtKitapSayfa.Location = new System.Drawing.Point(261, 211);
            this.txtKitapSayfa.Name = "txtKitapSayfa";
            this.txtKitapSayfa.Size = new System.Drawing.Size(236, 34);
            this.txtKitapSayfa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sayfa:";
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Roman",
            "Hikaye",
            "Tiyatro",
            "Sinema"});
            this.cmbTur.Location = new System.Drawing.Point(261, 251);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(236, 35);
            this.cmbTur.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(261, 292);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 31);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İkinciEl";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(388, 292);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 31);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pakette";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tür:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Durum:";
            // 
            // txtKitapId
            // 
            this.txtKitapId.Enabled = false;
            this.txtKitapId.Location = new System.Drawing.Point(261, 92);
            this.txtKitapId.Name = "txtKitapId";
            this.txtKitapId.Size = new System.Drawing.Size(236, 34);
            this.txtKitapId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kitap Id:";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(611, 88);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(155, 34);
            this.btnListele.TabIndex = 14;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(611, 222);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(155, 35);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(611, 134);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(155, 36);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(611, 182);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(155, 34);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(862, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtKitapBul
            // 
            this.txtKitapBul.Location = new System.Drawing.Point(721, 289);
            this.txtKitapBul.Name = "txtKitapBul";
            this.txtKitapBul.Size = new System.Drawing.Size(316, 34);
            this.txtKitapBul.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kitap Ad:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Bul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(882, 329);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(155, 34);
            this.btnAra.TabIndex = 22;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1164, 796);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKitapBul);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtKitapId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtKitapSayfa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKitapYazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtKitapYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKitapSayfa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKitapId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtKitapBul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAra;
    }
}


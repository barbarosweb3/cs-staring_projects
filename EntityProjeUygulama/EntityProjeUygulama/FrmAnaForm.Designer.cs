namespace EntityProjeUygulama
{
    partial class FrmAnaForm
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
            this.btnKategoriİslemleri = new System.Windows.Forms.Button();
            this.btnUrunİslemleri = new System.Windows.Forms.Button();
            this.btnIstatistikler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategoriİslemleri
            // 
            this.btnKategoriİslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKategoriİslemleri.Location = new System.Drawing.Point(12, 12);
            this.btnKategoriİslemleri.Name = "btnKategoriİslemleri";
            this.btnKategoriİslemleri.Size = new System.Drawing.Size(203, 159);
            this.btnKategoriİslemleri.TabIndex = 0;
            this.btnKategoriİslemleri.Text = "Kategori İşlemleri";
            this.btnKategoriİslemleri.UseVisualStyleBackColor = true;
            this.btnKategoriİslemleri.Click += new System.EventHandler(this.btnKategoriİslemleri_Click);
            // 
            // btnUrunİslemleri
            // 
            this.btnUrunİslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunİslemleri.Location = new System.Drawing.Point(221, 12);
            this.btnUrunİslemleri.Name = "btnUrunİslemleri";
            this.btnUrunİslemleri.Size = new System.Drawing.Size(203, 159);
            this.btnUrunİslemleri.TabIndex = 1;
            this.btnUrunİslemleri.Text = "Ürün İşlemleri";
            this.btnUrunİslemleri.UseVisualStyleBackColor = true;
            this.btnUrunİslemleri.Click += new System.EventHandler(this.btnUrunİslemleri_Click);
            // 
            // btnIstatistikler
            // 
            this.btnIstatistikler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIstatistikler.Location = new System.Drawing.Point(430, 12);
            this.btnIstatistikler.Name = "btnIstatistikler";
            this.btnIstatistikler.Size = new System.Drawing.Size(203, 159);
            this.btnIstatistikler.TabIndex = 2;
            this.btnIstatistikler.Text = "İstatistikler";
            this.btnIstatistikler.UseVisualStyleBackColor = true;
            this.btnIstatistikler.Click += new System.EventHandler(this.btnIstatistikler_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 193);
            this.Controls.Add(this.btnIstatistikler);
            this.Controls.Add(this.btnUrunİslemleri);
            this.Controls.Add(this.btnKategoriİslemleri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKategoriİslemleri;
        private System.Windows.Forms.Button btnUrunİslemleri;
        private System.Windows.Forms.Button btnIstatistikler;
    }
}
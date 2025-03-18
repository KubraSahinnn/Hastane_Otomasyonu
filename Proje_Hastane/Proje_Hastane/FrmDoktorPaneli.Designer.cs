namespace Proje_Hastane
{
    partial class FrmDoktorPaneli
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
            this.lblBrans = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.mskSifre = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Location = new System.Drawing.Point(70, 165);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(72, 28);
            this.lblBrans.TabIndex = 0;
            this.lblBrans.Text = "Branş:";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(148, 157);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(154, 36);
            this.cmbBrans.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(97, 55);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(45, 28);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(65, 112);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(77, 28);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(148, 47);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(154, 36);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(148, 104);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(154, 36);
            this.txtSoyad.TabIndex = 2;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(80, 263);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(62, 28);
            this.lblSifre.TabIndex = 6;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(65, 210);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(77, 28);
            this.lblTc.TabIndex = 7;
            this.lblTc.Text = "TC No:";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(148, 210);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(154, 36);
            this.mskTc.TabIndex = 4;
            // 
            // mskSifre
            // 
            this.mskSifre.Location = new System.Drawing.Point(148, 263);
            this.mskSifre.Name = "mskSifre";
            this.mskSifre.Size = new System.Drawing.Size(154, 36);
            this.mskSifre.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(359, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 334);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEkle.Location = new System.Drawing.Point(148, 319);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(78, 34);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSil.Location = new System.Drawing.Point(232, 319);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(70, 34);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGuncelle.Location = new System.Drawing.Point(148, 359);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(154, 34);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1079, 426);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mskSifre);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.lblBrans);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPaneli";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.MaskedTextBox mskSifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}
namespace Proje_Hastane
{
    partial class FrmBilgiDuzenle
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuncelle.Location = new System.Drawing.Point(273, 378);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(116, 39);
            this.btnGuncelle.TabIndex = 30;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmCinsiyet
            // 
            this.cmCinsiyet.FormattingEnabled = true;
            this.cmCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmCinsiyet.Location = new System.Drawing.Point(209, 283);
            this.cmCinsiyet.Name = "cmCinsiyet";
            this.cmCinsiyet.Size = new System.Drawing.Size(180, 36);
            this.cmCinsiyet.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefon Numarası:";
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(209, 229);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(180, 36);
            this.mskTelefon.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(209, 70);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(180, 36);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(209, 121);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(180, 36);
            this.txtSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ad:";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(209, 176);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(180, 36);
            this.mskTc.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(209, 327);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(180, 36);
            this.txtSifre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Şifre:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(62, 179);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(141, 28);
            this.label.TabIndex = 18;
            this.label.Text = "TC Kimlik No:";
            // 
            // FrmBilgiDuzenle
            // 
            this.AcceptButton = this.btnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(506, 485);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmBilgiDuzenle";
            this.Text = "Bilgi Düzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
    }
}
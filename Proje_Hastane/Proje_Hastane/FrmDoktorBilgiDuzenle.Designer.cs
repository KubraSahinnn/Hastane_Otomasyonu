namespace Proje_Hastane
{
    partial class FrmDoktorBilgiDuzenle
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBrans = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuncelle.Location = new System.Drawing.Point(281, 315);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(116, 39);
            this.btnGuncelle.TabIndex = 43;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(217, 53);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(180, 36);
            this.txtAd.TabIndex = 38;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(217, 104);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(180, 36);
            this.txtSoyad.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ad:";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(217, 159);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(180, 36);
            this.mskTc.TabIndex = 34;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(217, 273);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(180, 36);
            this.txtSifre.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 32;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "TC Kimlik No:";
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Location = new System.Drawing.Point(139, 223);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(72, 28);
            this.lblBrans.TabIndex = 44;
            this.lblBrans.Text = "Branş:";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(217, 215);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(180, 36);
            this.cmbBrans.TabIndex = 45;
            // 
            // FrmDoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(518, 501);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.lblBrans);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDoktorBilgiDuzenle";
            this.Text = "FrmDoktorBilgiDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.ComboBox cmbBrans;
    }
}
namespace Proje_Hastane
{
    partial class FrmHastaKayit
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
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnKayıtYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(210, 153);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(180, 36);
            this.mskTc.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(210, 304);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(180, 36);
            this.txtSifre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Soyad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(210, 98);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(180, 36);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(210, 47);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(180, 36);
            this.txtAd.TabIndex = 0;
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(210, 206);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(180, 36);
            this.mskTelefon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefon Numarası:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cinsiyet:";
            // 
            // cmCinsiyet
            // 
            this.cmCinsiyet.FormattingEnabled = true;
            this.cmCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmCinsiyet.Location = new System.Drawing.Point(210, 260);
            this.cmCinsiyet.Name = "cmCinsiyet";
            this.cmCinsiyet.Size = new System.Drawing.Size(180, 36);
            this.cmCinsiyet.TabIndex = 5;
            // 
            // btnKayıtYap
            // 
            this.btnKayıtYap.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnKayıtYap.Location = new System.Drawing.Point(248, 346);
            this.btnKayıtYap.Name = "btnKayıtYap";
            this.btnKayıtYap.Size = new System.Drawing.Size(116, 39);
            this.btnKayıtYap.TabIndex = 17;
            this.btnKayıtYap.Text = "Kayıt Yap";
            this.btnKayıtYap.UseVisualStyleBackColor = false;
            this.btnKayıtYap.Click += new System.EventHandler(this.btnKayıtYap_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnKayıtYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(443, 475);
            this.Controls.Add(this.btnKayıtYap);
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
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmCinsiyet;
        private System.Windows.Forms.Button btnKayıtYap;
    }
}
namespace Proje_Hastane
{
    partial class FrmDoktorDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchsikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnDuyuru = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Null Null";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(36, 38);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(108, 28);
            this.lblAdSoyad.TabIndex = 11;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "00000000000";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(67, 82);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(77, 28);
            this.lblTc.TabIndex = 7;
            this.lblTc.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchsikayet);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 254);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rchsikayet
            // 
            this.rchsikayet.Location = new System.Drawing.Point(22, 35);
            this.rchsikayet.Name = "rchsikayet";
            this.rchsikayet.Size = new System.Drawing.Size(218, 189);
            this.rchsikayet.TabIndex = 11;
            this.rchsikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(353, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 591);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(468, 556);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(6, 35);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 35);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Bilgi Düzenle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCikis);
            this.groupBox4.Controls.Add(this.btnDuyuru);
            this.groupBox4.Controls.Add(this.btnGuncelle);
            this.groupBox4.Location = new System.Drawing.Point(12, 465);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 138);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(80, 88);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(150, 35);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // btnDuyuru
            // 
            this.btnDuyuru.Location = new System.Drawing.Point(162, 35);
            this.btnDuyuru.Name = "btnDuyuru";
            this.btnDuyuru.Size = new System.Drawing.Size(148, 35);
            this.btnDuyuru.TabIndex = 1;
            this.btnDuyuru.Text = "Duyurular";
            this.btnDuyuru.UseVisualStyleBackColor = true;
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(868, 615);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDoktorDetay";
            this.Text = "FrmDoktorDetay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rchsikayet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDuyuru;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAdSoyad;
    }
}
namespace Proje_Hastane
{
    partial class FrmBrans
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBrans = new System.Windows.Forms.TextBox();
            this.txtBransid = new System.Windows.Forms.TextBox();
            this.lblBransAd = new System.Windows.Forms.Label();
            this.lblBransid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGuncelle.Location = new System.Drawing.Point(133, 217);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(154, 34);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSil.Location = new System.Drawing.Point(217, 177);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(70, 34);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEkle.Location = new System.Drawing.Point(133, 177);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(78, 34);
            this.btnEkle.TabIndex = 25;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(395, 204);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtBrans
            // 
            this.txtBrans.Location = new System.Drawing.Point(133, 102);
            this.txtBrans.Name = "txtBrans";
            this.txtBrans.Size = new System.Drawing.Size(154, 36);
            this.txtBrans.TabIndex = 19;
            // 
            // txtBransid
            // 
            this.txtBransid.Location = new System.Drawing.Point(133, 45);
            this.txtBransid.Name = "txtBransid";
            this.txtBransid.Size = new System.Drawing.Size(154, 36);
            this.txtBransid.TabIndex = 18;
            // 
            // lblBransAd
            // 
            this.lblBransAd.AutoSize = true;
            this.lblBransAd.Location = new System.Drawing.Point(24, 110);
            this.lblBransAd.Name = "lblBransAd";
            this.lblBransAd.Size = new System.Drawing.Size(103, 28);
            this.lblBransAd.TabIndex = 17;
            this.lblBransAd.Text = "Branş Ad:";
            // 
            // lblBransid
            // 
            this.lblBransid.AutoSize = true;
            this.lblBransid.Location = new System.Drawing.Point(33, 53);
            this.lblBransid.Name = "lblBransid";
            this.lblBransid.Size = new System.Drawing.Size(94, 28);
            this.lblBransid.TabIndex = 16;
            this.lblBransid.Text = "Branş id:";
            // 
            // FrmBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(740, 295);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBrans);
            this.Controls.Add(this.txtBransid);
            this.Controls.Add(this.lblBransAd);
            this.Controls.Add(this.lblBransid);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmBrans";
            this.Text = "FrmBrans";
            this.Load += new System.EventHandler(this.FrmBrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBrans;
        private System.Windows.Forms.TextBox txtBransid;
        private System.Windows.Forms.Label lblBransAd;
        private System.Windows.Forms.Label lblBransid;
    }
}
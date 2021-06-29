
namespace DiziTakip_EntityCF
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
            if(disposing)
            { db.Dispose(); }
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.nudSezon = new System.Windows.Forms.NumericUpDown();
            this.nudBolum = new System.Windows.Forms.NumericUpDown();
            this.chkBittiMi = new System.Windows.Forms.CheckBox();
            this.dgvDiziler = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSezon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBolum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiziler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dizinin Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sezon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bölüm";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(18, 66);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(148, 26);
            this.txtAd.TabIndex = 3;
            // 
            // nudSezon
            // 
            this.nudSezon.Location = new System.Drawing.Point(208, 64);
            this.nudSezon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSezon.Name = "nudSezon";
            this.nudSezon.Size = new System.Drawing.Size(70, 26);
            this.nudSezon.TabIndex = 4;
            // 
            // nudBolum
            // 
            this.nudBolum.Location = new System.Drawing.Point(316, 64);
            this.nudBolum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudBolum.Name = "nudBolum";
            this.nudBolum.Size = new System.Drawing.Size(70, 26);
            this.nudBolum.TabIndex = 5;
            // 
            // chkBittiMi
            // 
            this.chkBittiMi.AutoSize = true;
            this.chkBittiMi.Location = new System.Drawing.Point(416, 68);
            this.chkBittiMi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBittiMi.Name = "chkBittiMi";
            this.chkBittiMi.Size = new System.Drawing.Size(84, 24);
            this.chkBittiMi.TabIndex = 6;
            this.chkBittiMi.Text = "Bitti Mi?";
            this.chkBittiMi.UseVisualStyleBackColor = true;
            // 
            // dgvDiziler
            // 
            this.dgvDiziler.AllowUserToAddRows = false;
            this.dgvDiziler.AllowUserToDeleteRows = false;
            this.dgvDiziler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiziler.Location = new System.Drawing.Point(24, 122);
            this.dgvDiziler.MultiSelect = false;
            this.dgvDiziler.Name = "dgvDiziler";
            this.dgvDiziler.ReadOnly = true;
            this.dgvDiziler.RowHeadersVisible = false;
            this.dgvDiziler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiziler.Size = new System.Drawing.Size(947, 375);
            this.dgvDiziler.TabIndex = 7;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(24, 514);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(106, 38);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(160, 514);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(99, 38);
            this.btnDuzenle.TabIndex = 9;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(528, 64);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(92, 28);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(661, 64);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(76, 28);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(786, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Arama";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(790, 64);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(148, 26);
            this.txtAra.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 593);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvDiziler);
            this.Controls.Add(this.chkBittiMi);
            this.Controls.Add(this.nudBolum);
            this.Controls.Add(this.nudSezon);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Dizi Takip Programı";
            ((System.ComponentModel.ISupportInitialize)(this.nudSezon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBolum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiziler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.NumericUpDown nudSezon;
        private System.Windows.Forms.NumericUpDown nudBolum;
        private System.Windows.Forms.CheckBox chkBittiMi;
        private System.Windows.Forms.DataGridView dgvDiziler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAra;
    }
}


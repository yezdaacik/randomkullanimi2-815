namespace random_kullanımı_2_815
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
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.btnDurum = new System.Windows.Forms.Button();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblGecen = new System.Windows.Forms.Label();
            this.lblTesekkur = new System.Windows.Forms.Label();
            this.lblTakdir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNotlar
            // 
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.Location = new System.Drawing.Point(161, 47);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(120, 186);
            this.lbNotlar.TabIndex = 0;
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(12, 47);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(95, 51);
            this.btnUret.TabIndex = 1;
            this.btnUret.Text = "Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // btnDurum
            // 
            this.btnDurum.Location = new System.Drawing.Point(12, 250);
            this.btnDurum.Name = "btnDurum";
            this.btnDurum.Size = new System.Drawing.Size(95, 51);
            this.btnDurum.TabIndex = 2;
            this.btnDurum.Text = "Geçme/kalma durum";
            this.btnDurum.UseVisualStyleBackColor = true;
            this.btnDurum.Click += new System.EventHandler(this.btnDurum_Click);
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Location = new System.Drawing.Point(158, 269);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(100, 13);
            this.lblKalan.TabIndex = 3;
            this.lblKalan.Text = "Kalan öğrenci sayısı";
            // 
            // lblGecen
            // 
            this.lblGecen.AutoSize = true;
            this.lblGecen.Location = new System.Drawing.Point(158, 288);
            this.lblGecen.Name = "lblGecen";
            this.lblGecen.Size = new System.Drawing.Size(105, 13);
            this.lblGecen.TabIndex = 4;
            this.lblGecen.Text = "Geçen öğrenci sayısı";
            // 
            // lblTesekkur
            // 
            this.lblTesekkur.AutoSize = true;
            this.lblTesekkur.Location = new System.Drawing.Point(158, 311);
            this.lblTesekkur.Name = "lblTesekkur";
            this.lblTesekkur.Size = new System.Drawing.Size(82, 13);
            this.lblTesekkur.TabIndex = 5;
            this.lblTesekkur.Text = "Teşekkür Sayısı";
            // 
            // lblTakdir
            // 
            this.lblTakdir.AutoSize = true;
            this.lblTakdir.Location = new System.Drawing.Point(158, 334);
            this.lblTakdir.Name = "lblTakdir";
            this.lblTakdir.Size = new System.Drawing.Size(65, 13);
            this.lblTakdir.TabIndex = 6;
            this.lblTakdir.Text = "Takdir sayısı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(326, 465);
            this.Controls.Add(this.lblTakdir);
            this.Controls.Add(this.lblTesekkur);
            this.Controls.Add(this.lblGecen);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.btnDurum);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.lbNotlar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNotlar;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Button btnDurum;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblGecen;
        private System.Windows.Forms.Label lblTesekkur;
        private System.Windows.Forms.Label lblTakdir;
    }
}


namespace OBS
{
    partial class AnaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnDevamsizlik = new System.Windows.Forms.Button();
            this.btnNotlar = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.btnDanisman = new System.Windows.Forms.Button();
            this.btnHesap = new System.Windows.Forms.Button();
            this.btnTranskript = new System.Windows.Forms.Button();
            this.btnSinavlar = new System.Windows.Forms.Button();
            this.btnAkademikTakvim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOgrenciAd = new System.Windows.Forms.Label();
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.lblBolum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDevamsizlik
            // 
            this.btnDevamsizlik.Location = new System.Drawing.Point(50, 120);
            this.btnDevamsizlik.Name = "btnDevamsizlik";
            this.btnDevamsizlik.Size = new System.Drawing.Size(200, 40);
            this.btnDevamsizlik.TabIndex = 0;
            this.btnDevamsizlik.Text = "Devamsızlık Durumu";
            this.btnDevamsizlik.UseVisualStyleBackColor = true;
            this.btnDevamsizlik.Click += new System.EventHandler(this.btnDevamsizlik_Click);
            // 
            // btnNotlar
            // 
            this.btnNotlar.Location = new System.Drawing.Point(50, 170);
            this.btnNotlar.Name = "btnNotlar";
            this.btnNotlar.Size = new System.Drawing.Size(200, 40);
            this.btnNotlar.TabIndex = 1;
            this.btnNotlar.Text = "Notlar";
            this.btnNotlar.UseVisualStyleBackColor = true;
            this.btnNotlar.Click += new System.EventHandler(this.btnNotlar_Click);
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.Location = new System.Drawing.Point(50, 220);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(200, 40);
            this.btnDuyurular.TabIndex = 2;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // btnDanisman
            // 
            this.btnDanisman.Location = new System.Drawing.Point(50, 270);
            this.btnDanisman.Name = "btnDanisman";
            this.btnDanisman.Size = new System.Drawing.Size(200, 40);
            this.btnDanisman.TabIndex = 3;
            this.btnDanisman.Text = "Danışman Bilgileri";
            this.btnDanisman.UseVisualStyleBackColor = true;
            this.btnDanisman.Click += new System.EventHandler(this.btnDanisman_Click);
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(50, 320);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(200, 40);
            this.btnHesap.TabIndex = 4;
            this.btnHesap.Text = "Hesap Ayarları";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // btnTranskript
            // 
            this.btnTranskript.Location = new System.Drawing.Point(50, 370);
            this.btnTranskript.Name = "btnTranskript";
            this.btnTranskript.Size = new System.Drawing.Size(200, 40);
            this.btnTranskript.TabIndex = 5;
            this.btnTranskript.Text = "Transkript";
            this.btnTranskript.UseVisualStyleBackColor = true;
            this.btnTranskript.Click += new System.EventHandler(this.btnTranskript_Click);
            // 
            // btnSinavlar
            // 
            this.btnSinavlar.Location = new System.Drawing.Point(50, 420);
            this.btnSinavlar.Name = "btnSinavlar";
            this.btnSinavlar.Size = new System.Drawing.Size(200, 40);
            this.btnSinavlar.TabIndex = 6;
            this.btnSinavlar.Text = "Sınav Takvimi";
            this.btnSinavlar.UseVisualStyleBackColor = true;
            this.btnSinavlar.Click += new System.EventHandler(this.btnSinavlar_Click);
            // 
            // btnAkademikTakvim
            // 
            this.btnAkademikTakvim.Location = new System.Drawing.Point(50, 470);
            this.btnAkademikTakvim.Name = "btnAkademikTakvim";
            this.btnAkademikTakvim.Size = new System.Drawing.Size(200, 40);
            this.btnAkademikTakvim.TabIndex = 7;
            this.btnAkademikTakvim.Text = "Akademik Takvim";
            this.btnAkademikTakvim.UseVisualStyleBackColor = true;
            this.btnAkademikTakvim.Click += new System.EventHandler(this.btnAkademikTakvim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Öğrenci Bilgi Sistemi";
            // 
            // lblOgrenciAd
            // 
            this.lblOgrenciAd.AutoSize = true;
            this.lblOgrenciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblOgrenciAd.Location = new System.Drawing.Point(50, 20);
            this.lblOgrenciAd.Name = "lblOgrenciAd";
            this.lblOgrenciAd.Size = new System.Drawing.Size(200, 20);
            this.lblOgrenciAd.TabIndex = 9;
            this.lblOgrenciAd.Text = "Ad Soyad";
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOgrenciNo.Location = new System.Drawing.Point(50, 40);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(100, 17);
            this.lblOgrenciNo.TabIndex = 10;
            this.lblOgrenciNo.Text = "Öğrenci No";
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBolum.Location = new System.Drawing.Point(50, 60);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(100, 17);
            this.lblBolum.TabIndex = 11;
            this.lblBolum.Text = "Bölüm";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 530);
            this.Controls.Add(this.lblBolum);
            this.Controls.Add(this.lblOgrenciNo);
            this.Controls.Add(this.lblOgrenciAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAkademikTakvim);
            this.Controls.Add(this.btnSinavlar);
            this.Controls.Add(this.btnTranskript);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.btnDanisman);
            this.Controls.Add(this.btnDuyurular);
            this.Controls.Add(this.btnNotlar);
            this.Controls.Add(this.btnDevamsizlik);
            this.Name = "AnaForm";
            this.Text = "Ana Sayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnDevamsizlik;
        private System.Windows.Forms.Button btnNotlar;
        private System.Windows.Forms.Button btnDuyurular;
        private System.Windows.Forms.Button btnDanisman;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Button btnTranskript;
        private System.Windows.Forms.Button btnSinavlar;
        private System.Windows.Forms.Button btnAkademikTakvim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOgrenciAd;
        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.Label lblBolum;
    }
} 
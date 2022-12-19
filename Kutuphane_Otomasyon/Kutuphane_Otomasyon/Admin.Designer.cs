namespace Kutuphane_Otomasyon
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonDuzenle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonCıkıs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxkuladi = new System.Windows.Forms.TextBox();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGetirKullanici = new System.Windows.Forms.TextBox();
            this.buttonKullaniciGetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(61, 212);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(105, 59);
            this.buttonEkle.TabIndex = 5;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonDuzenle
            // 
            this.buttonDuzenle.Enabled = false;
            this.buttonDuzenle.Location = new System.Drawing.Point(188, 212);
            this.buttonDuzenle.Name = "buttonDuzenle";
            this.buttonDuzenle.Size = new System.Drawing.Size(105, 59);
            this.buttonDuzenle.TabIndex = 6;
            this.buttonDuzenle.Text = "Düzenle";
            this.buttonDuzenle.UseVisualStyleBackColor = true;
            this.buttonDuzenle.Click += new System.EventHandler(this.buttonDuzenle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Enabled = false;
            this.buttonSil.Location = new System.Drawing.Point(319, 212);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(105, 59);
            this.buttonSil.TabIndex = 7;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonCıkıs
            // 
            this.buttonCıkıs.Location = new System.Drawing.Point(446, 212);
            this.buttonCıkıs.Name = "buttonCıkıs";
            this.buttonCıkıs.Size = new System.Drawing.Size(105, 59);
            this.buttonCıkıs.TabIndex = 8;
            this.buttonCıkıs.Text = "Çıkış Yap";
            this.buttonCıkıs.UseVisualStyleBackColor = true;
            this.buttonCıkıs.Click += new System.EventHandler(this.buttonCıkıs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(125, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(168, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre:";
            // 
            // textBoxkuladi
            // 
            this.textBoxkuladi.Location = new System.Drawing.Point(237, 90);
            this.textBoxkuladi.Name = "textBoxkuladi";
            this.textBoxkuladi.Size = new System.Drawing.Size(171, 23);
            this.textBoxkuladi.TabIndex = 11;
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.Location = new System.Drawing.Point(237, 132);
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.Size = new System.Drawing.Size(171, 23);
            this.textBoxsifre.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Düzenlemek İstediğiniz \r\nKullanıcı Adını Girin:";
            // 
            // textBoxGetirKullanici
            // 
            this.textBoxGetirKullanici.Location = new System.Drawing.Point(237, 33);
            this.textBoxGetirKullanici.Name = "textBoxGetirKullanici";
            this.textBoxGetirKullanici.Size = new System.Drawing.Size(171, 23);
            this.textBoxGetirKullanici.TabIndex = 14;
            // 
            // buttonKullaniciGetir
            // 
            this.buttonKullaniciGetir.Location = new System.Drawing.Point(446, 33);
            this.buttonKullaniciGetir.Name = "buttonKullaniciGetir";
            this.buttonKullaniciGetir.Size = new System.Drawing.Size(79, 22);
            this.buttonKullaniciGetir.TabIndex = 15;
            this.buttonKullaniciGetir.Text = "Getir";
            this.buttonKullaniciGetir.UseVisualStyleBackColor = true;
            this.buttonKullaniciGetir.Click += new System.EventHandler(this.buttonKullaniciGetir_Click);
            // 
            // Admin
            // 
            this.AcceptButton = this.buttonKullaniciGetir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCıkıs;
            this.ClientSize = new System.Drawing.Size(614, 312);
            this.Controls.Add(this.buttonKullaniciGetir);
            this.Controls.Add(this.textBoxGetirKullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.textBoxkuladi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCıkıs);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonDuzenle);
            this.Controls.Add(this.buttonEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonDuzenle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonCıkıs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxkuladi;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGetirKullanici;
        private System.Windows.Forms.Button buttonKullaniciGetir;
    }
}
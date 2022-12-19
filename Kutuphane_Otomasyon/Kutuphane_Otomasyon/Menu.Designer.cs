namespace Kutuphane_Otomasyon
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTopKitap = new System.Windows.Forms.Label();
            this.labelTopUye = new System.Windows.Forms.Label();
            this.buttonKitapOdunc = new System.Windows.Forms.Button();
            this.buttonKitapGeriAl = new System.Windows.Forms.Button();
            this.buttonKitapEkle = new System.Windows.Forms.Button();
            this.buttonKitapDuzenle = new System.Windows.Forms.Button();
            this.buttonUyeEkle = new System.Windows.Forms.Button();
            this.buttonUyeDuzenle = new System.Windows.Forms.Button();
            this.buttonKategoriEkle = new System.Windows.Forms.Button();
            this.buttonKategoriDuzenle = new System.Windows.Forms.Button();
            this.buttonListe = new System.Windows.Forms.Button();
            this.buttonCıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kütüphane Otomasyon Programı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(175, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lütfen Yapmak İstediğiniz İşlemi Seçiniz!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(110, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Toplam Üye Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(380, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Toplam Kitap Sayısı:";
            // 
            // labelTopKitap
            // 
            this.labelTopKitap.AutoSize = true;
            this.labelTopKitap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTopKitap.Location = new System.Drawing.Point(528, 534);
            this.labelTopKitap.Name = "labelTopKitap";
            this.labelTopKitap.Size = new System.Drawing.Size(17, 20);
            this.labelTopKitap.TabIndex = 12;
            this.labelTopKitap.Text = "0";
            // 
            // labelTopUye
            // 
            this.labelTopUye.AutoSize = true;
            this.labelTopUye.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTopUye.Location = new System.Drawing.Point(248, 534);
            this.labelTopUye.Name = "labelTopUye";
            this.labelTopUye.Size = new System.Drawing.Size(17, 20);
            this.labelTopUye.TabIndex = 11;
            this.labelTopUye.Text = "0";
            // 
            // buttonKitapOdunc
            // 
            this.buttonKitapOdunc.Location = new System.Drawing.Point(62, 119);
            this.buttonKitapOdunc.Name = "buttonKitapOdunc";
            this.buttonKitapOdunc.Size = new System.Drawing.Size(242, 60);
            this.buttonKitapOdunc.TabIndex = 13;
            this.buttonKitapOdunc.Text = "Kitap Ödünç";
            this.buttonKitapOdunc.UseVisualStyleBackColor = true;
            this.buttonKitapOdunc.Click += new System.EventHandler(this.buttonKitapOdunc_Click);
            // 
            // buttonKitapGeriAl
            // 
            this.buttonKitapGeriAl.Location = new System.Drawing.Point(354, 119);
            this.buttonKitapGeriAl.Name = "buttonKitapGeriAl";
            this.buttonKitapGeriAl.Size = new System.Drawing.Size(242, 60);
            this.buttonKitapGeriAl.TabIndex = 14;
            this.buttonKitapGeriAl.Text = "Kitap Geri Al";
            this.buttonKitapGeriAl.UseVisualStyleBackColor = true;
            this.buttonKitapGeriAl.Click += new System.EventHandler(this.buttonKitapGeriAl_Click);
            // 
            // buttonKitapEkle
            // 
            this.buttonKitapEkle.Location = new System.Drawing.Point(62, 197);
            this.buttonKitapEkle.Name = "buttonKitapEkle";
            this.buttonKitapEkle.Size = new System.Drawing.Size(242, 60);
            this.buttonKitapEkle.TabIndex = 15;
            this.buttonKitapEkle.Text = "Kitap Ekle";
            this.buttonKitapEkle.UseVisualStyleBackColor = true;
            this.buttonKitapEkle.Click += new System.EventHandler(this.buttonKitapEkle_Click);
            // 
            // buttonKitapDuzenle
            // 
            this.buttonKitapDuzenle.Location = new System.Drawing.Point(354, 197);
            this.buttonKitapDuzenle.Name = "buttonKitapDuzenle";
            this.buttonKitapDuzenle.Size = new System.Drawing.Size(242, 60);
            this.buttonKitapDuzenle.TabIndex = 16;
            this.buttonKitapDuzenle.Text = "Kitap Düzenle";
            this.buttonKitapDuzenle.UseVisualStyleBackColor = true;
            this.buttonKitapDuzenle.Click += new System.EventHandler(this.buttonKitapDuzenle_Click);
            // 
            // buttonUyeEkle
            // 
            this.buttonUyeEkle.Location = new System.Drawing.Point(62, 276);
            this.buttonUyeEkle.Name = "buttonUyeEkle";
            this.buttonUyeEkle.Size = new System.Drawing.Size(242, 60);
            this.buttonUyeEkle.TabIndex = 17;
            this.buttonUyeEkle.Text = "Üye Ekle";
            this.buttonUyeEkle.UseVisualStyleBackColor = true;
            this.buttonUyeEkle.Click += new System.EventHandler(this.buttonUyeEkle_Click);
            // 
            // buttonUyeDuzenle
            // 
            this.buttonUyeDuzenle.Location = new System.Drawing.Point(354, 276);
            this.buttonUyeDuzenle.Name = "buttonUyeDuzenle";
            this.buttonUyeDuzenle.Size = new System.Drawing.Size(242, 60);
            this.buttonUyeDuzenle.TabIndex = 18;
            this.buttonUyeDuzenle.Text = "Üye Düzenle";
            this.buttonUyeDuzenle.UseVisualStyleBackColor = true;
            this.buttonUyeDuzenle.Click += new System.EventHandler(this.buttonUyeDuzenle_Click);
            // 
            // buttonKategoriEkle
            // 
            this.buttonKategoriEkle.Location = new System.Drawing.Point(62, 356);
            this.buttonKategoriEkle.Name = "buttonKategoriEkle";
            this.buttonKategoriEkle.Size = new System.Drawing.Size(242, 60);
            this.buttonKategoriEkle.TabIndex = 19;
            this.buttonKategoriEkle.Text = "Kategori Ekle";
            this.buttonKategoriEkle.UseVisualStyleBackColor = true;
            this.buttonKategoriEkle.Click += new System.EventHandler(this.buttonKategoriEkle_Click);
            // 
            // buttonKategoriDuzenle
            // 
            this.buttonKategoriDuzenle.Location = new System.Drawing.Point(354, 356);
            this.buttonKategoriDuzenle.Name = "buttonKategoriDuzenle";
            this.buttonKategoriDuzenle.Size = new System.Drawing.Size(242, 60);
            this.buttonKategoriDuzenle.TabIndex = 20;
            this.buttonKategoriDuzenle.Text = "Kategori Düzenle";
            this.buttonKategoriDuzenle.UseVisualStyleBackColor = true;
            this.buttonKategoriDuzenle.Click += new System.EventHandler(this.buttonKategoriDuzenle_Click);
            // 
            // buttonListe
            // 
            this.buttonListe.Location = new System.Drawing.Point(62, 439);
            this.buttonListe.Name = "buttonListe";
            this.buttonListe.Size = new System.Drawing.Size(242, 60);
            this.buttonListe.TabIndex = 21;
            this.buttonListe.Text = "Listeler";
            this.buttonListe.UseVisualStyleBackColor = true;
            this.buttonListe.Click += new System.EventHandler(this.buttonListe_Click);
            // 
            // buttonCıkıs
            // 
            this.buttonCıkıs.Location = new System.Drawing.Point(354, 439);
            this.buttonCıkıs.Name = "buttonCıkıs";
            this.buttonCıkıs.Size = new System.Drawing.Size(242, 60);
            this.buttonCıkıs.TabIndex = 22;
            this.buttonCıkıs.Text = "Çıkış Yap";
            this.buttonCıkıs.UseVisualStyleBackColor = true;
            this.buttonCıkıs.Click += new System.EventHandler(this.buttonCıkıs_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCıkıs;
            this.ClientSize = new System.Drawing.Size(678, 590);
            this.Controls.Add(this.buttonCıkıs);
            this.Controls.Add(this.buttonListe);
            this.Controls.Add(this.buttonKategoriDuzenle);
            this.Controls.Add(this.buttonKategoriEkle);
            this.Controls.Add(this.buttonUyeDuzenle);
            this.Controls.Add(this.buttonUyeEkle);
            this.Controls.Add(this.buttonKitapDuzenle);
            this.Controls.Add(this.buttonKitapEkle);
            this.Controls.Add(this.buttonKitapGeriAl);
            this.Controls.Add(this.buttonKitapOdunc);
            this.Controls.Add(this.labelTopKitap);
            this.Controls.Add(this.labelTopUye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTopKitap;
        private System.Windows.Forms.Label labelTopUye;
        private System.Windows.Forms.Button buttonKitapOdunc;
        private System.Windows.Forms.Button buttonKitapGeriAl;
        private System.Windows.Forms.Button buttonKitapEkle;
        private System.Windows.Forms.Button buttonKitapDuzenle;
        private System.Windows.Forms.Button buttonUyeEkle;
        private System.Windows.Forms.Button buttonUyeDuzenle;
        private System.Windows.Forms.Button buttonKategoriEkle;
        private System.Windows.Forms.Button buttonKategoriDuzenle;
        private System.Windows.Forms.Button buttonListe;
        private System.Windows.Forms.Button buttonCıkıs;
    }
}
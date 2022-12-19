namespace Kutuphane_Otomasyon
{
    partial class KategoriDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategoriDuzenle));
            this.buttonKategoriGetir = new System.Windows.Forms.Button();
            this.buttonKategoriDuzenle = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.textBoxKatAd = new System.Windows.Forms.TextBox();
            this.buttonKategoriSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxgetirKod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonKategoriGetir
            // 
            this.buttonKategoriGetir.Location = new System.Drawing.Point(365, 48);
            this.buttonKategoriGetir.Name = "buttonKategoriGetir";
            this.buttonKategoriGetir.Size = new System.Drawing.Size(75, 23);
            this.buttonKategoriGetir.TabIndex = 0;
            this.buttonKategoriGetir.Text = "Getir";
            this.buttonKategoriGetir.UseVisualStyleBackColor = true;
            this.buttonKategoriGetir.Click += new System.EventHandler(this.buttonKategoriGetir_Click);
            // 
            // buttonKategoriDuzenle
            // 
            this.buttonKategoriDuzenle.Location = new System.Drawing.Point(83, 239);
            this.buttonKategoriDuzenle.Name = "buttonKategoriDuzenle";
            this.buttonKategoriDuzenle.Size = new System.Drawing.Size(100, 45);
            this.buttonKategoriDuzenle.TabIndex = 1;
            this.buttonKategoriDuzenle.Text = "Düzenle";
            this.buttonKategoriDuzenle.UseVisualStyleBackColor = true;
            this.buttonKategoriDuzenle.Click += new System.EventHandler(this.buttonKategoriDuzenle_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(326, 239);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(100, 45);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Ana Menü";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori Adı:";
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(171, 106);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(167, 23);
            this.textBoxKod.TabIndex = 5;
            this.textBoxKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxgetirKod_KeyPress);
            // 
            // textBoxKatAd
            // 
            this.textBoxKatAd.Location = new System.Drawing.Point(171, 166);
            this.textBoxKatAd.Name = "textBoxKatAd";
            this.textBoxKatAd.Size = new System.Drawing.Size(167, 23);
            this.textBoxKatAd.TabIndex = 6;
            // 
            // buttonKategoriSil
            // 
            this.buttonKategoriSil.Location = new System.Drawing.Point(206, 239);
            this.buttonKategoriSil.Name = "buttonKategoriSil";
            this.buttonKategoriSil.Size = new System.Drawing.Size(100, 45);
            this.buttonKategoriSil.TabIndex = 7;
            this.buttonKategoriSil.Text = "Sil";
            this.buttonKategoriSil.UseVisualStyleBackColor = true;
            this.buttonKategoriSil.Click += new System.EventHandler(this.buttonKategoriSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Düzenlemek İstediğiniz \r\nKategori Kodunu Giriniz:";
            // 
            // textBoxgetirKod
            // 
            this.textBoxgetirKod.Location = new System.Drawing.Point(171, 48);
            this.textBoxgetirKod.Name = "textBoxgetirKod";
            this.textBoxgetirKod.Size = new System.Drawing.Size(167, 23);
            this.textBoxgetirKod.TabIndex = 9;
            this.textBoxgetirKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxgetirKod_KeyPress);
            // 
            // KategoriDuzenle
            // 
            this.AcceptButton = this.buttonKategoriGetir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonMenu;
            this.ClientSize = new System.Drawing.Size(504, 353);
            this.Controls.Add(this.textBoxgetirKod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonKategoriSil);
            this.Controls.Add(this.textBoxKatAd);
            this.Controls.Add(this.textBoxKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonKategoriDuzenle);
            this.Controls.Add(this.buttonKategoriGetir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KategoriDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Düzenle";
            this.Load += new System.EventHandler(this.KategoriDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKategoriGetir;
        private System.Windows.Forms.Button buttonKategoriDuzenle;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.TextBox textBoxKatAd;
        private System.Windows.Forms.Button buttonKategoriSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxgetirKod;
    }
}
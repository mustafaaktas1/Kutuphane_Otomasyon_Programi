namespace Kutuphane_Otomasyon
{
    partial class KitapDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapDuzenle));
            this.buttonKitapSil = new System.Windows.Forms.Button();
            this.buttonKitapGuncelle = new System.Windows.Forms.Button();
            this.buttonKitapGetir = new System.Windows.Forms.Button();
            this.textBoxKitapNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxYazar = new System.Windows.Forms.TextBox();
            this.textBoxSayfa = new System.Windows.Forms.TextBox();
            this.textBoxKitapAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.comboBoxDuzenleRaf = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonKitapSil
            // 
            this.buttonKitapSil.Location = new System.Drawing.Point(185, 312);
            this.buttonKitapSil.Name = "buttonKitapSil";
            this.buttonKitapSil.Size = new System.Drawing.Size(113, 47);
            this.buttonKitapSil.TabIndex = 19;
            this.buttonKitapSil.Text = "Sil";
            this.buttonKitapSil.UseVisualStyleBackColor = true;
            this.buttonKitapSil.Click += new System.EventHandler(this.buttonKitapSil_Click);
            // 
            // buttonKitapGuncelle
            // 
            this.buttonKitapGuncelle.Location = new System.Drawing.Point(46, 312);
            this.buttonKitapGuncelle.Name = "buttonKitapGuncelle";
            this.buttonKitapGuncelle.Size = new System.Drawing.Size(113, 47);
            this.buttonKitapGuncelle.TabIndex = 18;
            this.buttonKitapGuncelle.Text = "Güncelle";
            this.buttonKitapGuncelle.UseVisualStyleBackColor = true;
            this.buttonKitapGuncelle.Click += new System.EventHandler(this.buttonKitapGuncelle_Click);
            // 
            // buttonKitapGetir
            // 
            this.buttonKitapGetir.Location = new System.Drawing.Point(324, 21);
            this.buttonKitapGetir.Name = "buttonKitapGetir";
            this.buttonKitapGetir.Size = new System.Drawing.Size(75, 23);
            this.buttonKitapGetir.TabIndex = 17;
            this.buttonKitapGetir.Text = "Getir";
            this.buttonKitapGetir.UseVisualStyleBackColor = true;
            this.buttonKitapGetir.Click += new System.EventHandler(this.buttonKitapGetir_Click);
            // 
            // textBoxKitapNo
            // 
            this.textBoxKitapNo.Location = new System.Drawing.Point(198, 21);
            this.textBoxKitapNo.Name = "textBoxKitapNo";
            this.textBoxKitapNo.Size = new System.Drawing.Size(100, 23);
            this.textBoxKitapNo.TabIndex = 16;
            this.textBoxKitapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKitapNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Düzenlenecek Kitap\r\n         Numarası:";
            // 
            // textBoxYazar
            // 
            this.textBoxYazar.Location = new System.Drawing.Point(171, 149);
            this.textBoxYazar.Name = "textBoxYazar";
            this.textBoxYazar.Size = new System.Drawing.Size(241, 23);
            this.textBoxYazar.TabIndex = 27;
            // 
            // textBoxSayfa
            // 
            this.textBoxSayfa.Location = new System.Drawing.Point(171, 193);
            this.textBoxSayfa.Name = "textBoxSayfa";
            this.textBoxSayfa.Size = new System.Drawing.Size(100, 23);
            this.textBoxSayfa.TabIndex = 26;
            this.textBoxSayfa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKitapNo_KeyPress);
            // 
            // textBoxKitapAd
            // 
            this.textBoxKitapAd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxKitapAd.Location = new System.Drawing.Point(171, 105);
            this.textBoxKitapAd.Name = "textBoxKitapAd";
            this.textBoxKitapAd.Size = new System.Drawing.Size(241, 23);
            this.textBoxKitapAd.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(103, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Yazarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(96, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sayfası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(66, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Raf Konumu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kitap Adı:";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(324, 312);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(113, 47);
            this.buttonMenu.TabIndex = 19;
            this.buttonMenu.Text = "Ana Menü";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // comboBoxDuzenleRaf
            // 
            this.comboBoxDuzenleRaf.FormattingEnabled = true;
            this.comboBoxDuzenleRaf.Location = new System.Drawing.Point(171, 240);
            this.comboBoxDuzenleRaf.Name = "comboBoxDuzenleRaf";
            this.comboBoxDuzenleRaf.Size = new System.Drawing.Size(241, 23);
            this.comboBoxDuzenleRaf.TabIndex = 30;
            // 
            // KitapDuzenle
            // 
            this.AcceptButton = this.buttonKitapGetir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonMenu;
            this.ClientSize = new System.Drawing.Size(523, 416);
            this.Controls.Add(this.comboBoxDuzenleRaf);
            this.Controls.Add(this.textBoxYazar);
            this.Controls.Add(this.textBoxSayfa);
            this.Controls.Add(this.textBoxKitapAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonKitapSil);
            this.Controls.Add(this.buttonKitapGuncelle);
            this.Controls.Add(this.buttonKitapGetir);
            this.Controls.Add(this.textBoxKitapNo);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Düzenle";
            this.Load += new System.EventHandler(this.KitapDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKitapSil;
        private System.Windows.Forms.Button buttonKitapGuncelle;
        private System.Windows.Forms.Button buttonKitapGetir;
        private System.Windows.Forms.TextBox textBoxKitapNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxYazar;
        private System.Windows.Forms.TextBox textBoxSayfa;
        private System.Windows.Forms.TextBox textBoxKitapAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.ComboBox comboBoxDuzenleRaf;
    }
}
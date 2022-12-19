namespace Kutuphane_Otomasyon
{
    partial class KitapEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKitapAd = new System.Windows.Forms.TextBox();
            this.textBoxSayfa = new System.Windows.Forms.TextBox();
            this.textBoxYazar = new System.Windows.Forms.TextBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.comboBoxRaf = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Raf Konumu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(72, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sayfası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(79, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yazarı:";
            // 
            // textBoxKitapAd
            // 
            this.textBoxKitapAd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxKitapAd.Location = new System.Drawing.Point(141, 39);
            this.textBoxKitapAd.Name = "textBoxKitapAd";
            this.textBoxKitapAd.Size = new System.Drawing.Size(241, 23);
            this.textBoxKitapAd.TabIndex = 5;
            // 
            // textBoxSayfa
            // 
            this.textBoxSayfa.Location = new System.Drawing.Point(141, 127);
            this.textBoxSayfa.Name = "textBoxSayfa";
            this.textBoxSayfa.Size = new System.Drawing.Size(100, 23);
            this.textBoxSayfa.TabIndex = 7;
            this.textBoxSayfa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSayfa_KeyPress);
            // 
            // textBoxYazar
            // 
            this.textBoxYazar.Location = new System.Drawing.Point(141, 83);
            this.textBoxYazar.Name = "textBoxYazar";
            this.textBoxYazar.Size = new System.Drawing.Size(241, 23);
            this.textBoxYazar.TabIndex = 8;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(242, 242);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(112, 36);
            this.buttonMenu.TabIndex = 12;
            this.buttonMenu.Text = "Ana Menü";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(78, 242);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(112, 36);
            this.buttonEkle.TabIndex = 13;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // comboBoxRaf
            // 
            this.comboBoxRaf.FormattingEnabled = true;
            this.comboBoxRaf.Location = new System.Drawing.Point(141, 173);
            this.comboBoxRaf.Name = "comboBoxRaf";
            this.comboBoxRaf.Size = new System.Drawing.Size(241, 23);
            this.comboBoxRaf.TabIndex = 14;
            // 
            // KitapEkle
            // 
            this.AcceptButton = this.buttonEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonMenu;
            this.ClientSize = new System.Drawing.Size(462, 331);
            this.Controls.Add(this.comboBoxRaf);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.textBoxYazar);
            this.Controls.Add(this.textBoxSayfa);
            this.Controls.Add(this.textBoxKitapAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekleme";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKitapAd;
        private System.Windows.Forms.TextBox textBoxSayfa;
        private System.Windows.Forms.TextBox textBoxYazar;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.ComboBox comboBoxRaf;
    }
}
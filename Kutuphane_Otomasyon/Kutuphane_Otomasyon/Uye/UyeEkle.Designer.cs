namespace Kutuphane_Otomasyon
{
    partial class UyeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTCNo = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTelNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUyeEkle = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonE = new System.Windows.Forms.RadioButton();
            this.radioButtonK = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik Numarası:";
            // 
            // textBoxTCNo
            // 
            this.textBoxTCNo.Location = new System.Drawing.Point(194, 47);
            this.textBoxTCNo.MaxLength = 11;
            this.textBoxTCNo.Name = "textBoxTCNo";
            this.textBoxTCNo.Size = new System.Drawing.Size(173, 23);
            this.textBoxTCNo.TabIndex = 1;
            this.textBoxTCNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelNo_KeyPress);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(194, 102);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(173, 23);
            this.textBoxAd.TabIndex = 7;
            this.textBoxAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAd_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adı:";
            // 
            // textBoxTelNo
            // 
            this.textBoxTelNo.Location = new System.Drawing.Point(194, 243);
            this.textBoxTelNo.MaxLength = 10;
            this.textBoxTelNo.Name = "textBoxTelNo";
            this.textBoxTelNo.Size = new System.Drawing.Size(173, 23);
            this.textBoxTelNo.TabIndex = 11;
            this.textBoxTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefon Numarası:";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(194, 154);
            this.textBoxSoyad.MaxLength = 11;
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(173, 23);
            this.textBoxSoyad.TabIndex = 9;
            this.textBoxSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAd_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyadı:";
            // 
            // buttonUyeEkle
            // 
            this.buttonUyeEkle.Location = new System.Drawing.Point(76, 302);
            this.buttonUyeEkle.Name = "buttonUyeEkle";
            this.buttonUyeEkle.Size = new System.Drawing.Size(119, 37);
            this.buttonUyeEkle.TabIndex = 12;
            this.buttonUyeEkle.Text = "Kaydet";
            this.buttonUyeEkle.UseVisualStyleBackColor = true;
            this.buttonUyeEkle.Click += new System.EventHandler(this.buttonUyeEkle_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(248, 302);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(119, 37);
            this.buttonMenu.TabIndex = 13;
            this.buttonMenu.Text = "Ana Menü";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cinsiyeti:";
            // 
            // radioButtonE
            // 
            this.radioButtonE.AutoSize = true;
            this.radioButtonE.Location = new System.Drawing.Point(216, 205);
            this.radioButtonE.Name = "radioButtonE";
            this.radioButtonE.Size = new System.Drawing.Size(31, 19);
            this.radioButtonE.TabIndex = 15;
            this.radioButtonE.TabStop = true;
            this.radioButtonE.Text = "E";
            this.radioButtonE.UseVisualStyleBackColor = true;
            // 
            // radioButtonK
            // 
            this.radioButtonK.AutoSize = true;
            this.radioButtonK.Location = new System.Drawing.Point(273, 205);
            this.radioButtonK.Name = "radioButtonK";
            this.radioButtonK.Size = new System.Drawing.Size(32, 19);
            this.radioButtonK.TabIndex = 16;
            this.radioButtonK.TabStop = true;
            this.radioButtonK.Text = "K";
            this.radioButtonK.UseVisualStyleBackColor = true;
            // 
            // UyeEkle
            // 
            this.AcceptButton = this.buttonUyeEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonMenu;
            this.ClientSize = new System.Drawing.Size(451, 400);
            this.Controls.Add(this.radioButtonK);
            this.Controls.Add(this.radioButtonE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonUyeEkle);
            this.Controls.Add(this.textBoxTelNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTCNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UyeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTCNo;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTelNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUyeEkle;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonE;
        private System.Windows.Forms.RadioButton radioButtonK;
    }
}
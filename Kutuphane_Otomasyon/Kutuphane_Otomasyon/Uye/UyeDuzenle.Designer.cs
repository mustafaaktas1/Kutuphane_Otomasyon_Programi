namespace Kutuphane_Otomasyon
{
    partial class UyeDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeDuzenle));
            this.textBoxTelNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTCNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetir = new System.Windows.Forms.Button();
            this.buttonUyeDuzenle = new System.Windows.Forms.Button();
            this.buttonUyeSil = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonE = new System.Windows.Forms.RadioButton();
            this.radioButtonK = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBoxTelNo
            // 
            this.textBoxTelNo.Location = new System.Drawing.Point(186, 242);
            this.textBoxTelNo.MaxLength = 10;
            this.textBoxTelNo.Name = "textBoxTelNo";
            this.textBoxTelNo.Size = new System.Drawing.Size(173, 23);
            this.textBoxTelNo.TabIndex = 19;
            this.textBoxTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTCNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Telefon Numarası:";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(186, 150);
            this.textBoxSoyad.MaxLength = 11;
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(173, 23);
            this.textBoxSoyad.TabIndex = 17;
            this.textBoxSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAdi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Soyadı:";
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(186, 98);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(173, 23);
            this.textBoxAdi.TabIndex = 15;
            this.textBoxAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAdi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adı:";
            // 
            // textBoxTCNo
            // 
            this.textBoxTCNo.Location = new System.Drawing.Point(186, 43);
            this.textBoxTCNo.MaxLength = 11;
            this.textBoxTCNo.Name = "textBoxTCNo";
            this.textBoxTCNo.Size = new System.Drawing.Size(173, 23);
            this.textBoxTCNo.TabIndex = 13;
            this.textBoxTCNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTCNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "TC Kimlik Numarası:";
            // 
            // buttonGetir
            // 
            this.buttonGetir.Location = new System.Drawing.Point(393, 43);
            this.buttonGetir.Name = "buttonGetir";
            this.buttonGetir.Size = new System.Drawing.Size(75, 23);
            this.buttonGetir.TabIndex = 20;
            this.buttonGetir.Text = "Getir";
            this.buttonGetir.UseVisualStyleBackColor = true;
            this.buttonGetir.Click += new System.EventHandler(this.buttonGetir_Click);
            // 
            // buttonUyeDuzenle
            // 
            this.buttonUyeDuzenle.Location = new System.Drawing.Point(57, 305);
            this.buttonUyeDuzenle.Name = "buttonUyeDuzenle";
            this.buttonUyeDuzenle.Size = new System.Drawing.Size(99, 41);
            this.buttonUyeDuzenle.TabIndex = 21;
            this.buttonUyeDuzenle.Text = "Güncelle";
            this.buttonUyeDuzenle.UseVisualStyleBackColor = true;
            this.buttonUyeDuzenle.Click += new System.EventHandler(this.buttonUyeDuzenle_Click);
            // 
            // buttonUyeSil
            // 
            this.buttonUyeSil.Location = new System.Drawing.Point(186, 305);
            this.buttonUyeSil.Name = "buttonUyeSil";
            this.buttonUyeSil.Size = new System.Drawing.Size(99, 41);
            this.buttonUyeSil.TabIndex = 21;
            this.buttonUyeSil.Text = "Sil";
            this.buttonUyeSil.UseVisualStyleBackColor = true;
            this.buttonUyeSil.Click += new System.EventHandler(this.buttonUyeSil_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(331, 305);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(99, 41);
            this.buttonMenu.TabIndex = 21;
            this.buttonMenu.Text = "Ana Menü";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cinsiyeti:";
            // 
            // radioButtonE
            // 
            this.radioButtonE.AutoSize = true;
            this.radioButtonE.Location = new System.Drawing.Point(191, 198);
            this.radioButtonE.Name = "radioButtonE";
            this.radioButtonE.Size = new System.Drawing.Size(31, 19);
            this.radioButtonE.TabIndex = 23;
            this.radioButtonE.TabStop = true;
            this.radioButtonE.Text = "E";
            this.radioButtonE.UseVisualStyleBackColor = true;
            // 
            // radioButtonK
            // 
            this.radioButtonK.AutoSize = true;
            this.radioButtonK.Location = new System.Drawing.Point(265, 198);
            this.radioButtonK.Name = "radioButtonK";
            this.radioButtonK.Size = new System.Drawing.Size(32, 19);
            this.radioButtonK.TabIndex = 24;
            this.radioButtonK.TabStop = true;
            this.radioButtonK.Text = "K";
            this.radioButtonK.UseVisualStyleBackColor = true;
            // 
            // UyeDuzenle
            // 
            this.AcceptButton = this.buttonGetir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonMenu;
            this.ClientSize = new System.Drawing.Size(505, 390);
            this.Controls.Add(this.radioButtonK);
            this.Controls.Add(this.radioButtonE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonUyeSil);
            this.Controls.Add(this.buttonUyeDuzenle);
            this.Controls.Add(this.buttonGetir);
            this.Controls.Add(this.textBoxTelNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTCNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UyeDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Düzenle";
            this.Load += new System.EventHandler(this.UyeDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTelNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTCNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetir;
        private System.Windows.Forms.Button buttonUyeDuzenle;
        private System.Windows.Forms.Button buttonUyeSil;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonE;
        private System.Windows.Forms.RadioButton radioButtonK;
    }
}
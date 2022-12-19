namespace Kutuphane_Otomasyon
{
    partial class KitapOdunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapOdunc));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKitapNo = new System.Windows.Forms.TextBox();
            this.buttonKitapGetir = new System.Windows.Forms.Button();
            this.buttonUyeGetir = new System.Windows.Forms.Button();
            this.textBoxTcNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKitapAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxYazar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSayfa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRafKonum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTelefonNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUyeSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUyeAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonKitapOdunc = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonE = new System.Windows.Forms.RadioButton();
            this.radioButtonK = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Numarası:";
            // 
            // textBoxKitapNo
            // 
            this.textBoxKitapNo.Location = new System.Drawing.Point(139, 22);
            this.textBoxKitapNo.Name = "textBoxKitapNo";
            this.textBoxKitapNo.Size = new System.Drawing.Size(75, 23);
            this.textBoxKitapNo.TabIndex = 1;
            this.textBoxKitapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTcNo_KeyPress);
            // 
            // buttonKitapGetir
            // 
            this.buttonKitapGetir.Location = new System.Drawing.Point(236, 22);
            this.buttonKitapGetir.Name = "buttonKitapGetir";
            this.buttonKitapGetir.Size = new System.Drawing.Size(68, 23);
            this.buttonKitapGetir.TabIndex = 2;
            this.buttonKitapGetir.Text = "Getir";
            this.buttonKitapGetir.UseVisualStyleBackColor = true;
            this.buttonKitapGetir.Click += new System.EventHandler(this.buttonKitapGetir_Click);
            // 
            // buttonUyeGetir
            // 
            this.buttonUyeGetir.Location = new System.Drawing.Point(681, 25);
            this.buttonUyeGetir.Name = "buttonUyeGetir";
            this.buttonUyeGetir.Size = new System.Drawing.Size(68, 23);
            this.buttonUyeGetir.TabIndex = 5;
            this.buttonUyeGetir.Text = "Getir";
            this.buttonUyeGetir.UseVisualStyleBackColor = true;
            this.buttonUyeGetir.Click += new System.EventHandler(this.buttonUyeGetir_Click);
            // 
            // textBoxTcNo
            // 
            this.textBoxTcNo.Location = new System.Drawing.Point(535, 25);
            this.textBoxTcNo.MaxLength = 11;
            this.textBoxTcNo.Name = "textBoxTcNo";
            this.textBoxTcNo.Size = new System.Drawing.Size(122, 23);
            this.textBoxTcNo.TabIndex = 4;
            this.textBoxTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTcNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tc Kimlik Numarası:";
            // 
            // textBoxKitapAd
            // 
            this.textBoxKitapAd.Enabled = false;
            this.textBoxKitapAd.Location = new System.Drawing.Point(127, 87);
            this.textBoxKitapAd.Name = "textBoxKitapAd";
            this.textBoxKitapAd.Size = new System.Drawing.Size(158, 23);
            this.textBoxKitapAd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(63, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kitap Adı:";
            // 
            // textBoxYazar
            // 
            this.textBoxYazar.Enabled = false;
            this.textBoxYazar.Location = new System.Drawing.Point(127, 143);
            this.textBoxYazar.Name = "textBoxYazar";
            this.textBoxYazar.Size = new System.Drawing.Size(158, 23);
            this.textBoxYazar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(51, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kitap Yazarı:";
            // 
            // textBoxSayfa
            // 
            this.textBoxSayfa.Enabled = false;
            this.textBoxSayfa.Location = new System.Drawing.Point(127, 201);
            this.textBoxSayfa.Name = "textBoxSayfa";
            this.textBoxSayfa.Size = new System.Drawing.Size(158, 23);
            this.textBoxSayfa.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(51, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // textBoxRafKonum
            // 
            this.textBoxRafKonum.Enabled = false;
            this.textBoxRafKonum.Location = new System.Drawing.Point(127, 258);
            this.textBoxRafKonum.Name = "textBoxRafKonum";
            this.textBoxRafKonum.Size = new System.Drawing.Size(158, 23);
            this.textBoxRafKonum.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(42, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Raf  Konumu:";
            // 
            // textBoxTelefonNo
            // 
            this.textBoxTelefonNo.Enabled = false;
            this.textBoxTelefonNo.Location = new System.Drawing.Point(535, 258);
            this.textBoxTelefonNo.Name = "textBoxTelefonNo";
            this.textBoxTelefonNo.Size = new System.Drawing.Size(122, 23);
            this.textBoxTelefonNo.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(455, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Telefon No:";
            // 
            // textBoxUyeSoyad
            // 
            this.textBoxUyeSoyad.Enabled = false;
            this.textBoxUyeSoyad.Location = new System.Drawing.Point(535, 143);
            this.textBoxUyeSoyad.Name = "textBoxUyeSoyad";
            this.textBoxUyeSoyad.Size = new System.Drawing.Size(122, 23);
            this.textBoxUyeSoyad.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(454, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Üye Soyadı:";
            // 
            // textBoxUyeAd
            // 
            this.textBoxUyeAd.Enabled = false;
            this.textBoxUyeAd.Location = new System.Drawing.Point(535, 87);
            this.textBoxUyeAd.Name = "textBoxUyeAd";
            this.textBoxUyeAd.Size = new System.Drawing.Size(122, 23);
            this.textBoxUyeAd.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(471, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Üye Adı:";
            // 
            // buttonKitapOdunc
            // 
            this.buttonKitapOdunc.Location = new System.Drawing.Point(196, 330);
            this.buttonKitapOdunc.Name = "buttonKitapOdunc";
            this.buttonKitapOdunc.Size = new System.Drawing.Size(123, 46);
            this.buttonKitapOdunc.TabIndex = 20;
            this.buttonKitapOdunc.Text = "Kitabı Ödünç Ver";
            this.buttonKitapOdunc.UseVisualStyleBackColor = true;
            this.buttonKitapOdunc.Click += new System.EventHandler(this.buttonKitapOdunc_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(437, 330);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(123, 46);
            this.buttonMenu.TabIndex = 21;
            this.buttonMenu.Text = "Ana Menü";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(444, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Üye Cinsiyeti:";
            // 
            // radioButtonE
            // 
            this.radioButtonE.AutoSize = true;
            this.radioButtonE.Enabled = false;
            this.radioButtonE.Location = new System.Drawing.Point(545, 201);
            this.radioButtonE.Name = "radioButtonE";
            this.radioButtonE.Size = new System.Drawing.Size(31, 19);
            this.radioButtonE.TabIndex = 25;
            this.radioButtonE.TabStop = true;
            this.radioButtonE.Text = "E";
            this.radioButtonE.UseVisualStyleBackColor = true;
            // 
            // radioButtonK
            // 
            this.radioButtonK.AutoSize = true;
            this.radioButtonK.Enabled = false;
            this.radioButtonK.Location = new System.Drawing.Point(610, 201);
            this.radioButtonK.Name = "radioButtonK";
            this.radioButtonK.Size = new System.Drawing.Size(32, 19);
            this.radioButtonK.TabIndex = 26;
            this.radioButtonK.TabStop = true;
            this.radioButtonK.Text = "K";
            this.radioButtonK.UseVisualStyleBackColor = true;
            // 
            // KitapOdunc
            // 
            this.AcceptButton = this.buttonKitapOdunc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonMenu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonK);
            this.Controls.Add(this.radioButtonE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonKitapOdunc);
            this.Controls.Add(this.textBoxTelefonNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxUyeSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxUyeAd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxRafKonum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSayfa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxYazar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKitapAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUyeGetir);
            this.Controls.Add(this.textBoxTcNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonKitapGetir);
            this.Controls.Add(this.textBoxKitapNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapOdunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ödünç";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKitapNo;
        private System.Windows.Forms.Button buttonKitapGetir;
        private System.Windows.Forms.Button buttonUyeGetir;
        private System.Windows.Forms.TextBox textBoxTcNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKitapAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYazar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSayfa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRafKonum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTelefonNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxUyeSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUyeAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonKitapOdunc;
        
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonE;
        private System.Windows.Forms.RadioButton radioButtonK;
    }
}
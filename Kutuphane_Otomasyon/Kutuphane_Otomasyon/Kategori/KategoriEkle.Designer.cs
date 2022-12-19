namespace Kutuphane_Otomasyon
{
    partial class KategoriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategoriEkle));
            this.buttonEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKategoriNo = new System.Windows.Forms.TextBox();
            this.textBoxKategoriAd = new System.Windows.Forms.TextBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(63, 200);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(100, 45);
            this.buttonEkle.TabIndex = 0;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori Adı:";
            // 
            // textBoxKategoriNo
            // 
            this.textBoxKategoriNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKategoriNo.Location = new System.Drawing.Point(149, 49);
            this.textBoxKategoriNo.Name = "textBoxKategoriNo";
            this.textBoxKategoriNo.Size = new System.Drawing.Size(139, 25);
            this.textBoxKategoriNo.TabIndex = 2;
            this.textBoxKategoriNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKategoriNo_KeyPress);
            // 
            // textBoxKategoriAd
            // 
            this.textBoxKategoriAd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKategoriAd.Location = new System.Drawing.Point(149, 110);
            this.textBoxKategoriAd.Name = "textBoxKategoriAd";
            this.textBoxKategoriAd.Size = new System.Drawing.Size(139, 25);
            this.textBoxKategoriAd.TabIndex = 2;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(206, 200);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(100, 45);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.Text = "Ana Menü";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // KategoriEkle
            // 
            this.AcceptButton = this.buttonEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonMenu;
            this.ClientSize = new System.Drawing.Size(372, 293);
            this.Controls.Add(this.textBoxKategoriAd);
            this.Controls.Add(this.textBoxKategoriNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KategoriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKategoriNo;
        private System.Windows.Forms.TextBox textBoxKategoriAd;
        private System.Windows.Forms.Button buttonMenu;
    }
}
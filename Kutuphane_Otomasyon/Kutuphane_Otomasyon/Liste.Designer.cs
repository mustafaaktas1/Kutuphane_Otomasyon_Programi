namespace Kutuphane_Otomasyon
{
    partial class Liste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liste));
            this.buttonMenu = new System.Windows.Forms.Button();
            this.comboBoxListe = new System.Windows.Forms.ComboBox();
            this.dataGridViewListe = new System.Windows.Forms.DataGridView();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(577, 26);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(115, 31);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "Ana Menü";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // comboBoxListe
            // 
            this.comboBoxListe.FormattingEnabled = true;
            this.comboBoxListe.Items.AddRange(new object[] {
            "Tüm Kitaplar",
            "Tüm Üyeler",
            "Tüm Kategoriler",
            "Kitap Ödünç Alanlar"});
            this.comboBoxListe.Location = new System.Drawing.Point(39, 31);
            this.comboBoxListe.Name = "comboBoxListe";
            this.comboBoxListe.Size = new System.Drawing.Size(215, 23);
            this.comboBoxListe.TabIndex = 5;
            this.comboBoxListe.SelectedIndexChanged += new System.EventHandler(this.comboBoxListe_SelectedIndexChanged);
            // 
            // dataGridViewListe
            // 
            this.dataGridViewListe.AllowUserToAddRows = false;
            this.dataGridViewListe.AllowUserToDeleteRows = false;
            this.dataGridViewListe.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListe.Location = new System.Drawing.Point(12, 99);
            this.dataGridViewListe.Name = "dataGridViewListe";
            this.dataGridViewListe.ReadOnly = true;
            this.dataGridViewListe.RowTemplate.Height = 25;
            this.dataGridViewListe.Size = new System.Drawing.Size(836, 466);
            this.dataGridViewListe.TabIndex = 7;
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(298, 31);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.PlaceholderText = "Arama Yapın";
            this.textBoxAra.Size = new System.Drawing.Size(224, 23);
            this.textBoxAra.TabIndex = 8;
            this.textBoxAra.TextChanged += new System.EventHandler(this.comboBoxListe_SelectedIndexChanged);
            // 
            // Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonMenu;
            this.ClientSize = new System.Drawing.Size(859, 575);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.dataGridViewListe);
            this.Controls.Add(this.comboBoxListe);
            this.Controls.Add(this.buttonMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Liste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.ComboBox comboBoxListe;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.DataGridView dataGridViewListe;
        private System.Windows.Forms.TextBox textBoxAra;
    }
}
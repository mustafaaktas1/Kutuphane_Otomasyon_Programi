using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Kutuphane_Otomasyon
{
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        Connection connect = new Connection();

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }



        private void KitapEkle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Kategoriler";//combo box listesi
            komut.Connection = connect.con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            connect.con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxRaf.Items.Add(dr["RafKonumu"]);
            }
            comboBoxRaf.SelectedIndex = 0;
       
            connect.con.Close();

          
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {

            string kitapAd = "";
            string yazar = "";
            string sayfa = "";
            string raf = "";

            try
            {
                kitapAd = textBoxKitapAd.Text;
                yazar = textBoxYazar.Text;
                sayfa = textBoxSayfa.Text;
                raf = comboBoxRaf.Text;
            }
            catch (FormatException)
            {

                MessageBox.Show("Lütfen İlgili Alanlara Doğru Formatta Bilgi Giriniz!!! ", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            SqlCommand cmd = new SqlCommand("insert into Kitap (KitapAdi,KitapYazar,KitapSayfa,RafKonumu) values ('" + kitapAd + "','" + yazar + "','" + sayfa + "','" + raf + "')");


            if (textBoxKitapAd.Text == String.Empty || textBoxYazar.Text == String.Empty || textBoxSayfa.Text == String.Empty || comboBoxRaf.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show($"Kitap Adı: {kitapAd}\nKitap Yazarı:{yazar}\nSayfası:{sayfa}\nRaf Konumu:{raf}\nKitabı Eklemek İstiyormusunuz?", "Kitap Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (dialog == DialogResult.Yes)
                {
                    connect.con.Open();
                    cmd.Connection = connect.con;
                    cmd.ExecuteNonQuery();
                    connect.con.Close();
                    MessageBox.Show("Kitap Başarıyla Eklendi", "Kitap Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxKitapAd.Clear();
                    textBoxYazar.Clear();
                    textBoxSayfa.Clear();
                    comboBoxRaf.SelectedIndex = 0;
                }

            }




        }



        private void textBoxSayfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

      
    }
}

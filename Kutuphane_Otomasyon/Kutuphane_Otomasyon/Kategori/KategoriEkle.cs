using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class KategoriEkle : Form
    {
        public KategoriEkle()
        {
            InitializeComponent();
        }
        Connection connect = new Connection();
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Menu giris = new Menu();
            giris.Show();
            this.Close();
        }


        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string katno = "";
            string katad = "";
            string raf = "";


            try
            {
                katno = textBoxKategoriNo.Text;
                katad = textBoxKategoriAd.Text;
                raf = $"{textBoxKategoriNo.Text}-{textBoxKategoriAd.Text}";

            }
            catch (FormatException)
            {

                MessageBox.Show("Lütfen İlgili Alanlara Doğru Formatta Bilgi Giriniz!!! ", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            SqlCommand cmd = new SqlCommand("insert into Kategoriler (KategoriKodu,KategoriAdi,RafKonumu) values ('" + katno + "','" + katad + "','" + raf + "')");

            if (textBoxKategoriNo.Text == String.Empty || textBoxKategoriAd.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else if (Yinele(textBoxKategoriNo.Text) || Yinele(textBoxKategoriAd.Text))
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show($"Kategori No: {katno}\nKategori Adı:{katad}\nRaf Konumu:{raf}\nKategoriyi Eklemek İstiyormusunuz?", "Kategori Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (dialog == DialogResult.Yes)
                {
                    connect.con.Open();
                    cmd.Connection = connect.con;
                    cmd.ExecuteNonQuery();
                    connect.con.Close();
                    MessageBox.Show("Kategori Başarıyla Eklendi", "Kategori Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxKategoriNo.Clear();
                    textBoxKategoriAd.Clear();

                }
            }

            else
            {
                MessageBox.Show("Bu Kategori No yada Kategori Adı'na  ait kayıt bulunmaktadır. Lütfen tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




            bool Yinele(string data)
            {


                connect.con.Open();
                SqlCommand tekrar = new SqlCommand("select count(*) from Kategoriler where KategoriKodu='" + textBoxKategoriNo.Text + "'", connect.con);
                SqlCommand tekrar2 = new SqlCommand("select count(*) from Kategoriler where KategoriAdi='" + textBoxKategoriAd.Text + "'", connect.con);
                int sonuc = (int)tekrar.ExecuteScalar();
                int sonuc2 = (int)tekrar2.ExecuteScalar();

                if (sonuc > 0 || sonuc2 > 0)
                {
                    connect.con.Close();
                    return false; // veri tabanında var
                }
                else
                {
                    connect.con.Close();
                    return true; //veri tabanında yok
                }
            }


        }

        private void textBoxKategoriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

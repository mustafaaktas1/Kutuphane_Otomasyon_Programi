using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class Liste : Form
    {
        public Liste()
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


        private void comboBoxListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxListe.SelectedIndex == 0)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select KitapNo as 'Kitap No',KitapAdi as 'Kitap Adı',KitapYazar as 'Kitap Yazarı',KitapSayfa as 'Sayfa Sayısı',RafKonumu as 'Raf Konumu' From Kitap where KitapAdi Like '%" + textBoxAra.Text + "%'or KitapNo like '%" + textBoxAra.Text + "%' ", connect.con);
                DataSet ds = new DataSet();
                connect.con.Open();
                da.Fill(ds, "Kitap");
                dataGridViewListe.DataSource = ds.Tables["Kitap"];
                connect.con.Close();
            }

            else if (comboBoxListe.SelectedIndex == 1)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select ID as 'Sıra No',TCNo as 'TC No',Ad,Soyad,Cinsiyet,TelefonNo as 'Telefon No',KayitTarihi as 'Kayıt Tarihi' From Uye where Ad Like '%" + textBoxAra.Text + "%'or TCNo like '%" + textBoxAra.Text + "%' ", connect.con);
                DataSet ds = new DataSet();
                connect.con.Open();
                da.Fill(ds, "Uye");
                dataGridViewListe.DataSource = ds.Tables["Uye"];
                connect.con.Close();
            }
            else if (comboBoxListe.SelectedIndex == 2)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select ID as 'Sıra No',KategoriKodu as 'Kategori Kodu', KategoriAdi as 'Kategori Adı',RafKonumu as 'Raf Konumu'  From Kategoriler where KategoriAdi Like '%" + textBoxAra.Text + "%' ", connect.con);
                DataSet ds = new DataSet();
                connect.con.Open();
                da.Fill(ds, "Kategoriler");
                dataGridViewListe.DataSource = ds.Tables["Kategoriler"];
                connect.con.Close();
            }
            else if (comboBoxListe.SelectedIndex == 3)
            {

                SqlDataAdapter da = new SqlDataAdapter("Select KitabiAlanTc as 'Kitabı Alan TC No',KitabiAlanAd as 'Kitabı Alan Adı',KitabiAlanSoyad as 'Kitabı Alan Soyadı',KitapNo as 'Kitap No',KitapAd as'Kitabın Adı',AlisTarihi as 'Alış Tarihi',SonOkumaTarihi as'Son Okuma Tarihi' From Kayit where KitabiAlanAd Like '%" + textBoxAra.Text + "%' or KitapAd like '%" + textBoxAra.Text + "%' or KitapNo like '%" + textBoxAra.Text + "%' ", connect.con);
                DataSet ds = new DataSet();
                connect.con.Open();
                da.Fill(ds, "Kayit");
                dataGridViewListe.DataSource = ds.Tables["Kayit"];
                connect.con.Close();
            }


        }
    }
}

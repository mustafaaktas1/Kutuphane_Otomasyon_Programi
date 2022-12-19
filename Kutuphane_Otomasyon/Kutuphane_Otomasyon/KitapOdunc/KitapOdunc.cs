using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class KitapOdunc : Form
    {
        public KitapOdunc()
        {
            InitializeComponent();
        }
        Connection connect = new Connection();




        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Menu giris = new Menu();
            giris.Show();
            this.Hide();
        }



        private void buttonKitapGetir_Click(object sender, EventArgs e)
        {
            if (Yinele(textBoxKitapNo.Text))
            {
                SqlDataReader dr;
                string sorgu = "SELECT * FROM Kitap where KitapNo like '" + textBoxKitapNo.Text + "'";
                connect.con.Open();
                SqlCommand cmd = new SqlCommand(sorgu, connect.con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    textBoxKitapAd.Text = dr["KitapAdi"].ToString();
                    textBoxYazar.Text = dr["KitapYazar"].ToString();
                    textBoxSayfa.Text = dr["KitapSayfa"].ToString();
                    textBoxRafKonum.Text = dr["RafKonumu"].ToString();

                }
                connect.con.Close();
            }
            else
            {
                MessageBox.Show("Kitap Bulunamadı !", "Kitap Ödünç", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            bool Yinele(string data)
            {

                connect.con.Open();

                SqlCommand tekrar = new SqlCommand("select count(*) from Kitap where KitapNo='" + textBoxKitapNo.Text + "'", connect.con);

                int sonuc = (int)tekrar.ExecuteScalar();

                if (sonuc > 0)
                {
                    connect.con.Close();
                    return true; // veri tabanında var
                }
                else
                {
                    connect.con.Close();
                    return false; //veri tabanında yok
                }
            }
        }

        private void buttonUyeGetir_Click(object sender, EventArgs e)
        {

            if (Yinele(textBoxTcNo.Text))
            {
                string cinsiyet = "";
                SqlDataReader dr;
                string sorgu = "SELECT * FROM Uye where TCNo like '" + textBoxTcNo.Text + "'";
                connect.con.Open();
                SqlCommand cmd = new SqlCommand(sorgu, connect.con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    textBoxUyeAd.Text = dr["Ad"].ToString();
                    textBoxUyeSoyad.Text = dr["Soyad"].ToString();
                    textBoxTelefonNo.Text = dr["TelefonNo"].ToString();
                    cinsiyet = dr["Cinsiyet"].ToString();

                    if (cinsiyet == "E")
                    {
                        radioButtonE.Checked = true;
                    }
                    else if (cinsiyet == "K")
                    {
                        radioButtonK.Checked = true;
                    }
                }
                connect.con.Close();
            }
            else
            {
                MessageBox.Show("Üye Bulunamadı !", "Kitap Ödünç", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            bool Yinele(string data)
            {

                connect.con.Open();

                SqlCommand tekrar = new SqlCommand("select count(*) from Uye where TCNo='" + textBoxTcNo.Text + "'", connect.con);

                int sonuc = (int)tekrar.ExecuteScalar();

                if (sonuc > 0)
                {
                    connect.con.Close();
                    return true; // veri tabanında var
                }
                else
                {
                    connect.con.Close();
                    return false; //veri tabanında yok
                }
            }
        }



        private void buttonKitapOdunc_Click(object sender, EventArgs e)
        {

            string tc = "";
            string ad = "";
            string soyad = "";
            int kitapno = 0;
            string kitapad = "";
            string alis = "";
            string getirme = "";
            string raf = "";



            try
            {
                ad = textBoxUyeAd.Text;
                soyad = textBoxUyeSoyad.Text;
                kitapad = textBoxKitapAd.Text;

                raf = textBoxRafKonum.Text;
                alis = DateTime.Now.ToString("G");
                getirme = DateTime.Now.AddDays(15).ToString("dd.MM.yyyy");
                tc = textBoxTcNo.Text;
                kitapno = int.Parse(textBoxKitapNo.Text);

                SqlCommand cmd = new SqlCommand("insert into Kayit (KitabiAlanTc,KitabiAlanAd,KitabiAlanSoyad,KitapNo,KitapAd,RafKonum,AlisTarihi,SonOkumaTarihi) values ('" + tc + "','" + ad + "','" + soyad + "','" + kitapno + "','" + kitapad + "','" + raf + "','" + alis + "','" + getirme + "')");


                if (textBoxTcNo.Text == String.Empty || textBoxKitapNo.Text == String.Empty || textBoxKitapAd.Text == String.Empty || textBoxUyeAd.Text == String.Empty)
                {
                    MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                else if (Yinele(textBoxTcNo.Text) || Yinele(textBoxUyeAd.Text))
                {
                    if (Yinele2(textBoxKitapNo.Text) || Yinele2(textBoxKitapAd.Text))
                    {
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show($"Üye TC No:{tc}\nÜye Adı: {ad}\nÜye Soyadı:{soyad}\nKitap No:{kitapno}\nKitap Adı:{kitapad}\nKitabı Ödünç Vermek İstiyormusunuz?", "Kitap Ödünç Ver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                        if (dialog == DialogResult.Yes)
                        {
                            connect.con.Open();
                            cmd.Connection = connect.con;
                            cmd.ExecuteNonQuery();
                            connect.con.Close();
                            MessageBox.Show($"Kitap Ödünç Verildi\nÖdünç Verilme Tarihi:{alis}\nSon Okuma Tarihi (15 Gün):{getirme}", "Kitap Ödünç Ver", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            textBoxKitapAd.Clear();
                            textBoxUyeAd.Clear();
                            textBoxYazar.Clear();
                            textBoxUyeSoyad.Clear();
                            textBoxSayfa.Clear();
                            textBoxRafKonum.Clear();
                            textBoxTelefonNo.Clear();
                            radioButtonE.Checked = false;
                            radioButtonK.Checked = false;
                            textBoxKitapNo.Clear();
                            textBoxTcNo.Clear();
                        }

                    }

                    else
                    {
                        MessageBox.Show("Bu Kitap Başka Bir Üye Üzerinde Bulunmaktadır. Lütfen tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

                else
                {
                    MessageBox.Show("Bu Üyenin Üzerinde Kitap bulunmaktadır. Lütfen tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



                bool Yinele(string data)
                {

                    connect.con.Open();

                    SqlCommand tekrar = new SqlCommand("select count(*) from Kayit where KitabiAlanTc='" + textBoxTcNo.Text + "'", connect.con);
                    SqlCommand tekrar2 = new SqlCommand("select count(*) from Kayit where KitabiAlanAd='" + textBoxUyeAd.Text + "'", connect.con);


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

                bool Yinele2(string data)
                {

                    connect.con.Open();


                    SqlCommand tekrar2 = new SqlCommand("select count(*) from Kayit where KitapNo='" + textBoxKitapNo.Text + "'", connect.con);
                    SqlCommand tekrar3 = new SqlCommand("select count(*) from Kayit where KitapAd='" + textBoxKitapAd.Text + "'", connect.con);


                    int sonuc2 = (int)tekrar2.ExecuteScalar();
                    int sonuc3 = (int)tekrar3.ExecuteScalar();

                    if (sonuc2 > 0 || sonuc3 > 0)
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
            catch (FormatException)
            {

                MessageBox.Show("Lütfen İlgili Alanlara Doğru Formatta Bilgi Giriniz!!! ", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }//buton ödünç sonu

        private void textBoxTcNo_KeyPress(object sender, KeyPressEventArgs e)//sadece sayı girebilir
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}

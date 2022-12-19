using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
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

        
       
        public void buttonUyeEkle_Click(object sender, EventArgs e)
        {
            string cinsiyet = null;
            string tc = null;
            string ad = null;
            string soyad = null;
            string telno = null;

            try
            {
                tc = textBoxTCNo.Text;
                ad = textBoxAd.Text;
                soyad = textBoxSoyad.Text;
                telno = textBoxTelNo.Text;
            }
            catch (FormatException)
            {

                MessageBox.Show("Lütfen İlgili Alanlara Doğru Formatta Bilgi Giriniz!!! ", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (radioButtonE.Checked == true)
            {
                cinsiyet = "E";
            }
            else if (radioButtonK.Checked == true)
            {
                cinsiyet = "K";
            }

            SqlCommand cmd = new SqlCommand("insert into Uye (TCNo,Ad,Soyad,Cinsiyet,TelefonNo) values ('" + tc + "','" + ad + "','" + soyad + "','" + cinsiyet + "','" + telno + "')",connect.con);


            if (textBoxTCNo.Text == String.Empty || textBoxAd.Text == String.Empty || textBoxSoyad.Text == String.Empty || textBoxTelNo.Text == String.Empty || cinsiyet == null)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            else if (Yinele(textBoxTCNo.Text) || Yinele(textBoxTelNo.Text))
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show($"Üye TC No:{tc}\nÜye Adı: {ad}\nÜye Soyadı:{soyad}\nÜye Cinsiyeti:{cinsiyet}\nÜye Telefon No:{telno}\nÜyeyi Eklemek İstiyormusunuz?", "Üye Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (dialog == DialogResult.Yes)
                {
                    connect.con.Open();
                   // cmd.Connection = connect.con;
                    cmd.ExecuteNonQuery();
                    connect.con.Close();
                    MessageBox.Show("Üye Başarıyla Eklendi", "Üye Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxAd.Clear();
                    textBoxSoyad.Clear();
                    textBoxTCNo.Clear();
                    textBoxTelNo.Clear();
                    radioButtonE.Checked = false;
                    radioButtonK.Checked = false;
                }

            }
            else
            {
                MessageBox.Show("Bu TcNo yada Telefon No'ya  ait kayıt bulunmaktadır. Lütfen tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            bool Yinele(string data)
            {

                connect.con.Open();

                SqlCommand tekrar = new SqlCommand("select count(*) from Uye where TCNo='" + textBoxTCNo.Text + "'", connect.con);
                SqlCommand tekrar2 = new SqlCommand("select count(*) from Uye where TelefonNo='" + textBoxTelNo.Text + "'", connect.con);
                
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

        private void textBoxTelNo_KeyPress(object sender, KeyPressEventArgs e)//sadece rakam girişi denetimi
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       

        private void textBoxAd_KeyPress(object sender, KeyPressEventArgs e)//sadece harf girişi denetimi
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

       
    }
}

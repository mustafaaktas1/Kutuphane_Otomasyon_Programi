using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        Connection connect = new Connection();
        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Admin Paneli'nden çıkılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                Oturum oturum = new Oturum();
                oturum.Show();
                this.Close();

            }
        }

        private void buttonKullaniciGetir_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            string sorgu = "SELECT * FROM Admin where KullaniciAdi like '" + textBoxGetirKullanici.Text + "'";

            if (textBoxGetirKullanici.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Yinele2(textBoxGetirKullanici.Text))
            {
                connect.con.Open();
                SqlCommand cmd = new SqlCommand(sorgu, connect.con);
                dr = cmd.ExecuteReader();

                buttonEkle.Enabled = false;
                buttonDuzenle.Enabled = true;
                buttonSil.Enabled = true;
                while (dr.Read())
                {
                    textBoxkuladi.Text = dr["KullaniciAdi"].ToString();

                }

            }

            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı. Lütfen Tekrar Deneyin !", "Kullanıcı Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connect.con.Close();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("insert into Admin (KullaniciAdi,Sifre) values ('" + textBoxkuladi.Text + "','" + textBoxsifre.Text + "')");

            if (textBoxkuladi.Text == String.Empty || textBoxsifre.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else if (Yinele(textBoxkuladi.Text))
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show($"{textBoxkuladi.Text}\nKullanıcıyı Eklemek İstiyormusunuz?", "Kullanıcı Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (dialog == DialogResult.Yes)
                {
                    connect.con.Open();
                    cmd.Connection = connect.con;
                    cmd.ExecuteNonQuery();
                    connect.con.Close();
                    MessageBox.Show("Kullanıcı Başarıyla Eklendi", "Kullanıcı Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxGetirKullanici.Clear();
                    textBoxkuladi.Clear();
                    textBoxsifre.Clear();
                }
            }
            else
            {
                MessageBox.Show("Bu Kullanıcı Adı'na  ait kayıt bulunmaktadır. Lütfen tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }




        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Admin set KullaniciAdi='" + textBoxkuladi.Text + "',Sifre='" + textBoxsifre.Text + "' where KullaniciAdi='" + textBoxGetirKullanici.Text + "'");

            if (textBoxkuladi.Text == String.Empty || textBoxsifre.Text == String.Empty || textBoxGetirKullanici.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Yinele2(textBoxGetirKullanici.Text))
            {

                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Kullanıcıyı Düzenlemek İstiyormusunuz?", "Kullanıcı Düzenle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    connect.con.Open();
                    cmd.Connection = connect.con;
                    cmd.ExecuteNonQuery();
                    connect.con.Close();
                    MessageBox.Show("Kullanıcı Başarıyla Düzenlendi.", "Kullanıcı Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    buttonEkle.Enabled = true;
                    buttonDuzenle.Enabled = false;
                    buttonSil.Enabled = false;
                }

            }

            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı. Lütfen Tekrar Deneyin !", "Kullanıcı Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (textBoxkuladi.Text == String.Empty || textBoxGetirKullanici.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Yinele2(textBoxGetirKullanici.Text))
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Kullanıcıyı Silmek İstiyormusunuz?", "Kullanıcı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Delete From  Admin  Where KullaniciAdi='" + textBoxGetirKullanici.Text + "'");
                    connect.con.Open();
                    cmd.Connection = connect.con;
                    cmd.ExecuteNonQuery();
                    connect.con.Close();
                    MessageBox.Show("Kullanıcı Başarıyla Silindi.", "Kullanıcı Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    textBoxGetirKullanici.Clear();
                    textBoxkuladi.Clear();
                    buttonEkle.Enabled = true;
                    buttonDuzenle.Enabled = false;
                    buttonSil.Enabled = false;


                }
            }

            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı. Lütfen Tekrar Deneyin !", "Kullanıcı Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public bool Yinele(string data)
        {



           connect.con.Open();
            SqlCommand tekrar = new SqlCommand("select count(*) from Admin where KullaniciAdi='" + textBoxkuladi.Text + "'", connect.con);

            int sonuc = (int)tekrar.ExecuteScalar();



            if (sonuc > 0)
            {
                connect.con.Close();
                return false;
            }
            else
            {
                connect.con.Close();
                return true;
            }


        }
        public bool Yinele2(string data)
        {


            connect.con.Open();
            SqlCommand tekrar = new SqlCommand("select count(*) from Admin where KullaniciAdi='" + textBoxGetirKullanici.Text + "';", connect.con);

            int sonuc = (int)tekrar.ExecuteScalar();



            if (sonuc > 0)
            {
                connect.con.Close();
                return true;
            }
            else
            {
                connect.con.Close();
                return false;
            }


        }


    }
}


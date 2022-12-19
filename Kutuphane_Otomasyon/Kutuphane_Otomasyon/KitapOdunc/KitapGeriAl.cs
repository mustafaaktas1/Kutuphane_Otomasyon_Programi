using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class KitapGeriAl : Form
    {
        public KitapGeriAl()
        {
            InitializeComponent();
        }
        Connection connect = new Connection();
        private void button1_Click(object sender, EventArgs e)
        {
            Menu giris = new Menu();
            giris.Show();
            this.Close();
        }


        private void buttonKitapGetir_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            string sorgu = "SELECT * FROM Kayit where KitapNo like '" + textBoxKitapNo.Text + "'";


            if (textBoxKitapNo.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Yinele(textBoxKitapNo.Text))
            {
                connect.con.Open();
                SqlCommand cmd = new SqlCommand(sorgu, connect.con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    textBoxTcNo.Text = dr["KitabiAlanTc"].ToString();
                    textBoxUyeAd.Text = $"{dr["KitabiAlanAd"].ToString()} {dr["KitabiAlanSoyad"].ToString()}";
                    textBoxKitapAd.Text = dr["KitapAd"].ToString();
                    textBoxKitapNo.Text = dr["KitapNo"].ToString();
                    textBoxAlis.Text = dr["AlisTarihi"].ToString();
                    textBoxRaf.Text = dr["RafKonum"].ToString();
                    textBoxSonOkuma.Text = dr["SonOkumaTarihi"].ToString();

                }

            }
            else
            {
                MessageBox.Show("Kitap Ödünç Alınmamış. Lütfen Tekrar Deneyin !", "Kitap Geri Al", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            connect.con.Close();

        }

        private void buttonKitapGeriAl_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Kayit where KitapNo='" + textBoxKitapNo.Text + "'");

            if (textBoxKitapAd.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else if (Yinele(textBoxKitapNo.Text))
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show($"Üye TC No:{textBoxTcNo.Text}\nÜye Adı Soyadı: {textBoxUyeAd.Text}\nKitap Adı:{textBoxKitapAd.Text}\nKitap Rafı:{textBoxRaf.Text}\nKitabı Geri Almak İstiyormusunuz?", "Kitap Geri Al", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (dialog == DialogResult.Yes)
                {
                    connect.con.Open();
                    cmd.Connection = connect.con;
                    cmd.ExecuteNonQuery();
                    connect.con.Close();
                    MessageBox.Show("Kitap Başarıyla Geri Alındı", "Kitap Geri Al", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    textBoxTcNo.Clear();
                    textBoxUyeAd.Clear();
                    textBoxKitapAd.Clear();
                    textBoxKitapNo.Clear();
                    textBoxAlis.Clear();
                    textBoxRaf.Clear();
                    textBoxSonOkuma.Clear();
                }
            }


        }
        bool Yinele(string data)
        {


            connect.con.Open();
            SqlCommand tekrar = new SqlCommand("select count(*) from Kayit where KitapNo='" + textBoxKitapNo.Text + "'", connect.con);

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

        private void textBoxKitapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

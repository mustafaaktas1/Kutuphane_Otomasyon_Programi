using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class UyeDuzenle : Form
    {
        public UyeDuzenle()
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

        private void UyeDuzenle_Load(object sender, EventArgs e)
        {

        }

        private void buttonGetir_Click(object sender, EventArgs e)
        {
            string cinsiyet = null;
            SqlDataReader dr;
            string sorgu = "SELECT * FROM Uye where TCNo like '" + textBoxTCNo.Text + "'";
            if (textBoxTCNo.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Yinele(textBoxTCNo.Text))
            {
                connect.con.Open();
                SqlCommand cmd = new SqlCommand(sorgu, connect.con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    textBoxAdi.Text = dr["Ad"].ToString();
                    textBoxSoyad.Text = dr["Soyad"].ToString();
                    cinsiyet = dr["Cinsiyet"].ToString();
                    textBoxTelNo.Text = dr["TelefonNo"].ToString();

                    if (cinsiyet == "E")
                    {
                        radioButtonE.Checked = true;
                    }
                    else if (cinsiyet == "K")
                    {
                        radioButtonK.Checked = true;
                    }
                }

            }

            else
            {
                MessageBox.Show("Üye Bulunamadı. Lütfen Tekrar Deneyin !", "Üye Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connect.con.Close();
        }



        private void buttonUyeDuzenle_Click(object sender, EventArgs e)
        {
            string cinsiyet = null;

            if (radioButtonE.Checked == true)
            {
                cinsiyet = "E";

            }
            else if (radioButtonK.Checked == true)
            {
                cinsiyet = "K";

            }

            if (textBoxAdi.Text == String.Empty || textBoxSoyad.Text == String.Empty || textBoxTCNo.Text == String.Empty || textBoxTelNo.Text == String.Empty || cinsiyet == null)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Yinele(textBoxTCNo.Text))
            {

                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Üyeyi Düzenlemek İstiyormusunuz?", "Üye Düzenle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("update Uye set Ad='" + textBoxAdi.Text + "',Soyad='" + textBoxSoyad.Text + "',Cinsiyet='" + cinsiyet + "',TelefonNo='" + textBoxTelNo.Text + "' where TCNo=" + textBoxTCNo.Text + "");
                    connect.con.Open();
                    cmd.Connection = connect.con;
                    cmd.ExecuteNonQuery();
                    connect.con.Close();
                    MessageBox.Show("Üye Başarıyla Düzenlendi.", "Üye Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    textBoxAdi.Clear();
                    textBoxSoyad.Clear();
                    textBoxTCNo.Clear();
                    textBoxTelNo.Clear();
                    radioButtonE.Checked = false;
                    radioButtonK.Checked = false;
                }

            }

            else
            {
                MessageBox.Show("Üye Bulunamadı. Lütfen Tekrar Deneyin !", "Üye Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void buttonUyeSil_Click(object sender, EventArgs e)
        {
            string cinsiyet = null;

            if (cinsiyet == "E")
            {
                cinsiyet = "E";
                radioButtonE.Checked = true;

            }
            else if (cinsiyet == "K")
            {
                cinsiyet = "K";
                radioButtonK.Checked = true;

            }
            if (textBoxAdi.Text == String.Empty || textBoxSoyad.Text == String.Empty || textBoxTCNo.Text == String.Empty || textBoxTelNo.Text == String.Empty || cinsiyet == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Yinele(textBoxTCNo.Text))
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Üyeyi Silmek İstiyormusunuz?", "Üye Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Delete From Uye Where TCNo=" + textBoxTCNo.Text + "");
                    connect.con.Open();
                    cmd.Connection = connect.con;
                    cmd.ExecuteNonQuery();
                    connect.con.Close();

                    textBoxTCNo.Clear();
                    textBoxAdi.Clear();
                    textBoxSoyad.Clear();
                    textBoxTelNo.Clear();
                    radioButtonE.Checked = false;
                    radioButtonK.Checked = false;
                    MessageBox.Show("Üye Başarıyla Silindi.", "Üye Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Üye Bulunamadı. Lütfen Tekrar Deneyin !", "Üye Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public bool Yinele(string data)
        {


           connect.con.Open();
            SqlCommand tekrar = new SqlCommand("select count(*) from Uye where TCNo='" + textBoxTCNo.Text + "'", connect.con);

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

        private void textBoxTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }
    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class KategoriDuzenle : Form
    {
        public KategoriDuzenle()
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

        private void KategoriDuzenle_Load(object sender, EventArgs e)
        {

        }

        private void buttonKategoriGetir_Click(object sender, EventArgs e)
        {

            SqlDataReader dr;
            string sorgu = "SELECT * FROM Kategoriler where KategoriKodu like '" + textBoxgetirKod.Text + "'";

            if (textBoxgetirKod.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Yinele(textBoxgetirKod.Text))
            {
                connect.con.Open();
                SqlCommand cmd = new SqlCommand(sorgu,connect.con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    textBoxKod.Text = dr["KategoriKodu"].ToString();
                    textBoxKatAd.Text = dr["KategoriAdi"].ToString();

                }

            }

            else
            {
                MessageBox.Show("Kategori Bulunamadı. Lütfen Tekrar Deneyin !", "Kategori Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connect.con.Close();
        }



        private void buttonKategoriDuzenle_Click(object sender, EventArgs e)
        {

            if (textBoxKatAd.Text == String.Empty || textBoxKod.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Yinele(textBoxgetirKod.Text))
            {

                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Kategoriyi Düzenlemek İstiyormusunuz?", "Kategori Düzenle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("update Kategoriler set KategoriKodu='" + textBoxKod.Text + "',KategoriAdi='" + textBoxKatAd.Text + "',RafKonumu='" + textBoxKod.Text + "-" + textBoxKatAd.Text + "' where KategoriKodu=" + textBoxgetirKod.Text + "");
                    connect.con.Open();
                    cmd.Connection = connect.con;
                    cmd.ExecuteNonQuery();
                    connect.con.Close();
                    MessageBox.Show("Kategori Başarıyla Düzenlendi.", "Kategori Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    textBoxKod.Clear();
                    textBoxKatAd.Clear();
                }

            }

            else
            {
                MessageBox.Show("Kategori Bulunamadı. Lütfen Tekrar Deneyin !", "Kategori Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void buttonKategoriSil_Click(object sender, EventArgs e)
        {

            if (textBoxKatAd.Text == String.Empty || textBoxKod.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Yinele(textBoxgetirKod.Text))
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Kategoriyi Silmek İstiyormusunuz?", "Kategori Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Delete From  Kategoriler  Where KategoriKodu=" + textBoxgetirKod.Text + "");
                    connect.con.Open();
                    cmd.Connection = connect.con;
                    cmd.ExecuteNonQuery();
                    connect.con.Close();
                    MessageBox.Show("Kategori Başarıyla Silindi.", "Kategori Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    textBoxKod.Clear();
                    textBoxKatAd.Clear();


                }
            }

            else
            {
                MessageBox.Show("Kategori Bulunamadı. Lütfen Tekrar Deneyin !", "Kategori Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool Yinele(string data)
        {


            connect.con.Open();
            SqlCommand tekrar = new SqlCommand("select count(*) from Kategoriler where KategoriKodu='" + textBoxgetirKod.Text + "'", connect.con);

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

        private void textBoxgetirKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

       
    }
}

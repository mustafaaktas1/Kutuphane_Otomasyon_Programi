using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        Connection connect = new Connection();

        private void Giris_Load(object sender, EventArgs e)
        {

            string sorgu = "SELECT COUNT(*) FROM Kitap";
            string sorgu2 = "SELECT COUNT(*) FROM Uye";
            connect.con.Open();
            SqlCommand cmd = new SqlCommand(sorgu,connect.con);
            SqlCommand cmd2 = new SqlCommand(sorgu2,connect.con);

            labelTopKitap.Text = cmd.ExecuteScalar().ToString();
            labelTopUye.Text = cmd2.ExecuteScalar().ToString();
        }

        private void buttonKitapOdunc_Click(object sender, EventArgs e)
        {
            KitapOdunc kitapOdunc = new KitapOdunc();
            kitapOdunc.Show();
            this.Close();

            connect.con.Close();
        }

        private void buttonKitapGeriAl_Click(object sender, EventArgs e)
        {
            KitapGeriAl kitapGeriAl = new KitapGeriAl();
            kitapGeriAl.Show();
            this.Close();

            connect.con.Close();
        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkle kitapKayit = new KitapEkle();
            kitapKayit.Show();
            this.Close();

            connect.con.Close();
        }

        private void buttonKitapDuzenle_Click(object sender, EventArgs e)
        {
            KitapDuzenle kitapDuzenle = new KitapDuzenle();
            kitapDuzenle.Show();
            this.Close();

            connect.con.Close();
        }

        private void buttonUyeEkle_Click(object sender, EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.Show();
            this.Close();

            connect.con.Close();
        }

        private void buttonUyeDuzenle_Click(object sender, EventArgs e)
        {
            UyeDuzenle uyeDuzenle = new UyeDuzenle();
            uyeDuzenle.Show();
            this.Close();

            connect.con.Close();
        }

        private void buttonKategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriEkle kategoriEkle = new KategoriEkle();
            kategoriEkle.Show();
            this.Close();

            connect.con.Close();
        }

        private void buttonKategoriDuzenle_Click(object sender, EventArgs e)
        {
            KategoriDuzenle kategoriDuzenle = new KategoriDuzenle();
            kategoriDuzenle.Show();
            this.Close();

            connect.con.Close();
        }

        private void buttonListe_Click(object sender, EventArgs e)
        {
            Liste liste = new Liste();
            liste.Show();
            this.Close();

            connect.con.Close();
        }

        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                Oturum oturum = new Oturum();
                oturum.Show();
                this.Close();

            }
            connect.con.Close();

        }
        

    }
}

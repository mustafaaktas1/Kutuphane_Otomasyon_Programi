using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class KitapDuzenle : Form
    {
        public KitapDuzenle()
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



        private void KitapDuzenle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Kategoriler";
            komut.Connection = connect.con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            connect.con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxDuzenleRaf.Items.Add(dr["RafKonumu"]);
            }
            connect.con.Close();
        }



        private void buttonKitapGetir_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            string sorgu = "SELECT * FROM Kitap where KitapNo like '" + textBoxKitapNo.Text + "'";
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

                    textBoxKitapAd.Text = dr["KitapAdi"].ToString();
                    textBoxYazar.Text = dr["KitapYazar"].ToString();
                    textBoxSayfa.Text = dr["KitapSayfa"].ToString();
                    comboBoxDuzenleRaf.Text = dr["RafKonumu"].ToString();
                }

            }

            else
            {
                MessageBox.Show("Kitap Bulunamadı. Lütfen Tekrar Deneyin !", "Kitap Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connect.con.Close();
        }



        private void buttonKitapGuncelle_Click(object sender, EventArgs e)
        {

            if (textBoxKitapNo.Text == String.Empty || textBoxKitapAd.Text == String.Empty || textBoxYazar.Text == String.Empty || textBoxSayfa.Text == String.Empty || comboBoxDuzenleRaf.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Yinele(textBoxKitapNo.Text))
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Kitabı Düzenlemek İstiyormusunuz?", "Kitap Düzenle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("update Kitap set KitapAdi='" + textBoxKitapAd.Text + "',KitapYazar='" + textBoxYazar.Text + "',KitapSayfa='" + textBoxSayfa.Text + "',RafKonumu='" + comboBoxDuzenleRaf.Text + "' where KitapNo=" + textBoxKitapNo.Text + "");
                    connect.con.Open();
                    cmd.Connection = connect.con;
                    cmd.ExecuteNonQuery();
                    connect.con.Close();
                    MessageBox.Show("Kitap Başarıyla Düzenlendi.", "Kitap Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxKitapAd.Clear();
                    textBoxYazar.Clear();
                    textBoxSayfa.Clear();
                    comboBoxDuzenleRaf.SelectedIndex = 0;
                }
            }

            else
            {
                MessageBox.Show("Kitap Bulunamadı. Lütfen Tekrar Deneyin !", "Kitap Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void buttonKitapSil_Click(object sender, EventArgs e)
        {
            if (textBoxKitapNo.Text == String.Empty || textBoxKitapAd.Text == String.Empty || textBoxYazar.Text == String.Empty || textBoxSayfa.Text == String.Empty || comboBoxDuzenleRaf.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Yinele(textBoxKitapNo.Text))
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Kitabı Silmek İstiyormusunuz?", "Kitap Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Delete From Kitap Where KitapNo=" + textBoxKitapNo.Text + "");
                    connect.con.Open();
                    cmd.Connection = connect.con;
                    cmd.ExecuteNonQuery();
                    connect.con.Close();

                    MessageBox.Show("Kitap Başarıyla Silindi.", "Kitap Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxKitapNo.Clear();
                    textBoxKitapAd.Clear();
                    textBoxYazar.Clear();
                    textBoxSayfa.Clear();
                    comboBoxDuzenleRaf.SelectedIndex = 0;
                }
            }

            else
            {
                MessageBox.Show("Kitap Bulunamadı. Lütfen Tekrar Deneyin !", "Kitap Düzenle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool Yinele(string data)
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

        private void textBoxKitapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       
    }
}

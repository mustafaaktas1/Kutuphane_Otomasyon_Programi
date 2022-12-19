using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class Oturum : Form
    {
        public Oturum()
        {
            InitializeComponent();


        }
        Connection connect = new Connection();


        private void Oturum_Load(object sender, EventArgs e)
        {
            connect.con.Open();
        }




        private void buttonGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr;
                string sorgu = "SELECT * FROM Admin where KullaniciAdi=@user AND Sifre=@pass";

                SqlCommand cmd = new SqlCommand(sorgu, connect.con);
                cmd.Parameters.AddWithValue("@user", textBox_Kadi.Text);
                cmd.Parameters.AddWithValue("@pass", textBox_Sifre.Text);

                dr = cmd.ExecuteReader();


                if (textBox_Kadi.Text == "admin" && textBox_Sifre.Text == "admin" && dr.Read())
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Admin Paneline Girmek İstiyormusunuz? \nHayır'a Tıklarsanız Program Açılacaktır.", "Admin", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                        connect.con.Close();
                    }
                    else if (dialog == DialogResult.No)
                    {
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                        connect.con.Close();
                    }

                }


                else if (dr.Read())
                {
                    MessageBox.Show($"Hoşgeldiniz {textBox_Kadi.Text.ToUpper()}.", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu giris = new Menu();
                    giris.Show();
                    this.Hide();
                    connect.con.Close();
                }



                else
                {

                    MessageBox.Show("Kullanıcı adınızı ve şifrenizi kontrol ediniz.", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Kadi.Clear();
                    textBox_Sifre.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı adınızı ve şifrenizi kontrol ediniz.", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Oturum oturum = new Oturum();
                oturum.Show();
                this.Hide();

            }


        }
    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KÜLTÜR_SAĞLIK_TAKİP_UYGULAMASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DESKTOP-KT6O8E3\\SQLEXPRESS;Database=KulturSaglikDB;Trusted_Connection=True;";

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string tcKimlik = txtTcKimlik.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrWhiteSpace(tcKimlik) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    if (chkHasta.Checked) // **Hasta Girişi**
                    {
                        string query = "SELECT AdSoyad FROM Hastalar WHERE TcKimlikNo = @tc AND Sifre = @sifre";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@tc", tcKimlik);
                            cmd.Parameters.AddWithValue("@sifre", sifre);

                            SqlDataReader dr = cmd.ExecuteReader();

                            if (dr.Read())
                            {
                                string hastaAdi = dr["AdSoyad"].ToString().Trim();
                                AnaSayfa anaSayfa = new AnaSayfa(hastaAdi, tcKimlik);
                                anaSayfa.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Tc Kimlik veya Şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (chkPersonel.Checked) // **Personel Girişi**
                    {
                        string query = "SELECT YetkiSeviyesi FROM Personeller WHERE KullaniciAdi = @tc AND Sifre = @sifre";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@tc", tcKimlik);
                            cmd.Parameters.AddWithValue("@sifre", sifre);

                            object yetkiSonuc = cmd.ExecuteScalar();

                            if (yetkiSonuc != null)
                            {
                                PersonelGiris personelEkran = new PersonelGiris();
                                personelEkran.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen giriş türünü seçin! (Hasta veya Personel)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkHasta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHasta.Checked)
            {
                chkPersonel.Checked = false;
            }
        }

        private void chkPersonel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPersonel.Checked)
            {
                chkHasta.Checked = false;
            }
        }
    }
}

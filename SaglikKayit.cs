using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KÜLTÜR_SAĞLIK_TAKİP_UYGULAMASI
{
    public partial class SaglikKayit : Form
    {
        private string tcKimlik; // Kullanıcının TC Kimlik numarası
        private string connectionString = "Server=DESKTOP-KT6O8E3\\SQLEXPRESS;Database=KulturSaglikDB;Trusted_Connection=True;";

        public SaglikKayit(string tcKimlik)
        {
            InitializeComponent();
            this.tcKimlik = tcKimlik;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // 1️⃣ Tüm alanlar dolu mu kontrol et
            if (string.IsNullOrWhiteSpace(txtNabiz.Text) || string.IsNullOrWhiteSpace(txtKilo.Text) ||
                string.IsNullOrWhiteSpace(txtBoy.Text) || string.IsNullOrWhiteSpace(txtKaan.Text))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2️⃣ Kullanıcının sağlık bilgisi zaten var mı kontrol et
            if (SaglikKaydiVarMi())
            {
                MessageBox.Show("Zaten sağlık kaydınız var! Yeni bir kayıt ekleyemezsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3️⃣ Girişleri güvenli bir şekilde sayıya çevir
            if (!int.TryParse(txtNabiz.Text, out int nabiz) ||
                !float.TryParse(txtKilo.Text, out float kilo) ||
                !float.TryParse(txtBoy.Text, out float boy))
            {
                MessageBox.Show("Lütfen geçerli sayısal değerler girin!\n- Nabız: Tam sayı olmalı (örneğin 75)\n- Kilo: Ondalıklı olabilir (örneğin 70.5)\n- Boy: Ondalıklı olabilir (örneğin 1.75)",
                                "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO SaglikKayitlari (TcKimlikNo, KanBasinci, Nabiz, Kilo, Boy, Tarih) VALUES (@tc, @kan, @nabiz, @kilo, @boy, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tc", tcKimlik);
                        cmd.Parameters.AddWithValue("@kan", txtKaan.Text); // Kan basıncı (örnek: 120/80)
                        cmd.Parameters.AddWithValue("@nabiz", nabiz);
                        cmd.Parameters.AddWithValue("@kilo", kilo);
                        cmd.Parameters.AddWithValue("@boy", boy);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Sağlık bilgileri başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Kayıt yapıldıktan sonra formu kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaglikKaydiVarMi()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM SaglikKayitlari WHERE TcKimlikNo = @tc";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tc", tcKimlik);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0; // Eğer kayıt varsa true döner, yoksa false
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sağlık bilgileri kontrol edilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txtKaan_TextChanged(object sender, EventArgs e)
        {
            // Kullanıcının kan basıncı girişini takip edebiliriz.
        }

        private void txtBoy_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtKilo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // AnaSayfa zaten açıksa tekrar açma
            Form anaSayfa = Application.OpenForms["AnaSayfa"];

            if (anaSayfa != null)
            {
                anaSayfa.Show(); // Eğer açık olan bir AnaSayfa varsa onu göster
            }
            else
            {
                // Eğer AnaSayfa constructor'ı iki parametre istiyorsa, eksik olanı da eklemelisin.
                AnaSayfa yeniAnaSayfa = new AnaSayfa(tcKimlik, ""); // Eksik parametreyi uygun şekilde ver
                yeniAnaSayfa.Show();
            }

            this.Close(); // SağlıkKayit formunu kapat
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNabiz_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

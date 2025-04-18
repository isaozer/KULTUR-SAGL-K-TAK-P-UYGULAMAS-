using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KÜLTÜR_SAĞLIK_TAKİP_UYGULAMASI
{
    public partial class HastaKayit: Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DESKTOP-KT6O8E3\\SQLEXPRESS;Database=KulturSaglikDB;Trusted_Connection=True;";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            {
               
                string tcKimlik = txtTcKimlik.Text.Trim();
                string adSoyad = txtAdSoyad.Text.Trim();
                string sifre = txtSifre.Text.Trim();
                string dogumTarihi = dtpDogumTarihi.Value.ToString("yyyy-MM-dd"); // Tarihi SQL formatına çeviriyoruz.

                
                if (string.IsNullOrWhiteSpace(tcKimlik) || string.IsNullOrWhiteSpace(adSoyad) ||
                    string.IsNullOrWhiteSpace(sifre) || string.IsNullOrWhiteSpace(dogumTarihi))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "INSERT INTO Hastalar (TcKimlikNo, AdSoyad, Sifre, DogumTarihi) VALUES (@tc, @ad, @sifre, @dogumTarihi)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@tc", tcKimlik);
                            cmd.Parameters.AddWithValue("@ad", adSoyad);
                            cmd.Parameters.AddWithValue("@sifre", sifre);
                            cmd.Parameters.AddWithValue("@dogumTarihi", dogumTarihi);

                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Hasta kaydı başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Kayıt eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 anaForm = new Form1();
            anaForm.Show(); 
            this.Close(); 
        }
    }
}

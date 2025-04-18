using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KÜLTÜR_SAĞLIK_TAKİP_UYGULAMASI
{
    public partial class PersonelGiris : Form
    {
        private string connectionString = "Server=DESKTOP-KT6O8E3\\SQLEXPRESS;Database=KulturSaglikDB;Trusted_Connection=True;";
        private string secilenTcKimlik = "";

        public PersonelGiris()
        {
            InitializeComponent();
        }

        private void PersonelGiris_Load(object sender, EventArgs e)
        {
            TestSqlConnection();

            cmbSaglık.Items.Add("Sağlıklı");
            cmbSaglık.Items.Add("Sağlıksız");

            // 🔴 EVENT'İ GEÇİCİ OLARAK KAPAT
            cmbHastalar.SelectedIndexChanged -= cmbHastalar_SelectedIndexChanged_1;

            HastalariListele();

            // 🟢 EVENT'İ GERİ AÇ
            cmbHastalar.SelectedIndexChanged += cmbHastalar_SelectedIndexChanged_1;
        }

        private void TestSqlConnection()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Bağlantı Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HastalariListele()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT TcKimlikNo, AdSoyad FROM Hastalar";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        cmbHastalar.Items.Clear();
                        while (dr.Read())
                        {
                            string hastaBilgisi = $"{dr["AdSoyad"]} - {dr["TcKimlikNo"]}";
                            cmbHastalar.Items.Add(hastaBilgisi);
                        }
                        if (cmbHastalar.Items.Count > 0)
                            cmbHastalar.SelectedIndex = 0;
                    }
                }

                // ✅ COMBOBOX'I YENİDEN ÇİZ
                cmbHastalar.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hastalar listelenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbHastalar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbHastalar.SelectedItem != null)
            {
                string[] hastaBilgileri = cmbHastalar.SelectedItem.ToString().Split('-');
                if (hastaBilgileri.Length > 1)
                {
                    secilenTcKimlik = hastaBilgileri[1].Trim();
                    HastaSaglikBilgileriniGetir();
                }
            }
        }

        private void HastaSaglikBilgileriniGetir()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT SaglikDurumu, Notlar FROM SaglikKayitlari WHERE TcKimlikNo = @tc";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tc", secilenTcKimlik);
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            cmbSaglık.SelectedItem = dr["SaglikDurumu"].ToString();
                            guna2TextBox1.Text = dr["Notlar"].ToString();
                        }
                        else
                        {
                            cmbSaglık.SelectedIndex = -1;
                            guna2TextBox1.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sağlık bilgileri alınırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(secilenTcKimlik) || cmbSaglık.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir hasta seçin ve sağlık durumu belirleyin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string checkQuery = "SELECT COUNT(*) FROM SaglikKayitlari WHERE TcKimlikNo = @tc";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@tc", secilenTcKimlik);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            string insertQuery = "INSERT INTO SaglikKayitlari (TcKimlikNo, SaglikDurumu, Notlar) VALUES (@tc, @saglik, @not)";
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                            {
                                insertCmd.Parameters.AddWithValue("@tc", secilenTcKimlik);
                                insertCmd.Parameters.AddWithValue("@saglik", cmbSaglık.SelectedItem.ToString());
                                insertCmd.Parameters.AddWithValue("@not", guna2TextBox1.Text);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string updateQuery = "UPDATE SaglikKayitlari SET SaglikDurumu = @saglik, Notlar = @not WHERE TcKimlikNo = @tc";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@tc", secilenTcKimlik);
                                updateCmd.Parameters.AddWithValue("@saglik", cmbSaglık.SelectedItem.ToString());
                                updateCmd.Parameters.AddWithValue("@not", guna2TextBox1.Text);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Hasta bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HastaSaglikBilgileriniGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show("Hesabınızdan çıkış yapmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Restart(); 
                }
            }
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

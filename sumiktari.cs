using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KÜLTÜR_SAĞLIK_TAKİP_UYGULAMASI
{
    public partial class sumiktari : UserControl
    {
        private string tcKimlik;
        private string connectionString = "Server=DESKTOP-KT6O8E3\\SQLEXPRESS;Database=KulturSaglikDB;Trusted_Connection=True;";

        public sumiktari(string tcKimlik)
        {
            InitializeComponent();
            this.tcKimlik = tcKimlik;
        }

        private void sumiktari_Load(object sender, EventArgs e)
        {
            dtpBaslangic.Value = DateTime.Today.AddDays(-7); // Son 7 gün başlangıç
            dtpBitis.Value = DateTime.Today; // Bugün bitiş
            ToplamSuMiktariniGoster();
            SaglikGecmisiGrafikCiz();
        }

        private void btnSuEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSuMiktari.Text))
                {
                    MessageBox.Show("Lütfen içtiğiniz su miktarını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO SuTuketimi (TcKimlikNo, SuMiktari, Tarih) VALUES (@tc, @su, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tc", tcKimlik);
                        cmd.Parameters.AddWithValue("@su", Convert.ToSingle(txtSuMiktari.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Su tüketimi kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSuMiktari.Clear();
                ToplamSuMiktariniGoster();
                SaglikGecmisiGrafikCiz();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToplamSuMiktariniGoster()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT SUM(SuMiktari) AS ToplamSu FROM SuTuketimi WHERE TcKimlikNo = @tc";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tc", tcKimlik);
                        object toplamSu = cmd.ExecuteScalar();

                        if (toplamSu != DBNull.Value && toplamSu != null)
                        {
                            lblToplamSu.Text = "Toplam Su Tüketimi: " + toplamSu.ToString() + " L";
                        }
                        else
                        {
                            lblToplamSu.Text = "Henüz su tüketimi kaydı yok.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaglikGecmisiGrafikCiz()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT Tarih, SUM(SuMiktari) AS ToplamSu " +
                                   "FROM SuTuketimi WHERE TcKimlikNo = @tc " +
                                   "AND Tarih BETWEEN @startDate AND @endDate " +
                                   "GROUP BY Tarih ORDER BY Tarih ASC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tc", tcKimlik);
                        cmd.Parameters.AddWithValue("@startDate", dtpBaslangic.Value.Date);
                        cmd.Parameters.AddWithValue("@endDate", dtpBitis.Value.Date);

                        SqlDataReader dr = cmd.ExecuteReader();

                        // **Grafik Serisi Kontrol ve Ekleme**
                        if (!chartSuGecmisi.Series.Contains(chartSuGecmisi.Series.FindByName("SuTuketimi")))
                        {
                            chartSuGecmisi.Series.Add("SuTuketimi");
                        }

                        chartSuGecmisi.Series["SuTuketimi"].Points.Clear();

                        while (dr.Read())
                        {
                            DateTime tarih = Convert.ToDateTime(dr["Tarih"]);
                            float su = Convert.ToSingle(dr["ToplamSu"]);

                            chartSuGecmisi.Series["SuTuketimi"].Points.AddXY(tarih.ToShortDateString(), su);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartSuGecmisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grafiğe tıklandı!", "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

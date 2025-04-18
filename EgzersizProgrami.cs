using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KÜLTÜR_SAĞLIK_TAKİP_UYGULAMASI
{
    public partial class EgzersizProgrami : UserControl
    {
        private string tcKimlik;
        private string connectionString = "Server=DESKTOP-KT6O8E3\\SQLEXPRESS;Database=KulturSaglikDB;Trusted_Connection=True;";

        public EgzersizProgrami(string tcKimlik)
        {
            InitializeComponent();
            this.tcKimlik = tcKimlik;
        }

        private void EgzersizProgrami_Load(object sender, EventArgs e)
        {
            dtpTarih.Value = DateTime.Today;
            DataGridViewSutunlariEkle();  // DataGridView sütunlarını ekleyelim
            EgzersizleriListele();
            EgzersizGrafikCiz();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // **Butonun çalışıp çalışmadığını test et**
                MessageBox.Show("Butona basıldı!", "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kullanıcının egzersiz ve süre seçimlerini kontrol et
                if (cmbEgzersiz.SelectedItem == null || numSure.Value == 0)
                {
                    MessageBox.Show("Lütfen egzersiz türünü seçin ve süresini girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string egzersizAdi = cmbEgzersiz.SelectedItem.ToString();
                int sure = (int)numSure.Value;
                DateTime tarih = dtpTarih.Value;

                int kalori = sure * 5; // Ortalama 1 dakikada 5 kalori yakımı

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO EgzersizProgrami (TcKimlikNo, EgzersizAdi, Sure, Tarih, KaloriYakit) VALUES (@tc, @egzersiz, @sure, @tarih, @kalori)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tc", tcKimlik);
                        cmd.Parameters.AddWithValue("@egzersiz", egzersizAdi);
                        cmd.Parameters.AddWithValue("@sure", sure);
                        cmd.Parameters.AddWithValue("@tarih", tarih);
                        cmd.Parameters.AddWithValue("@kalori", kalori);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Egzersiz başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EgzersizleriListele();
                EgzersizGrafikCiz();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewSutunlariEkle()
        {
            // **Sütunlar yoksa ekle**
            if (dgvEgzersizler.Columns.Count == 0)
            {
                dgvEgzersizler.Columns.Clear();
                dgvEgzersizler.Columns.Add("EgzersizAdi", "Egzersiz Türü");
                dgvEgzersizler.Columns.Add("Sure", "Süre (dk)");
                dgvEgzersizler.Columns.Add("Tarih", "Tarih");
                dgvEgzersizler.Columns.Add("KaloriYakit", "Yakılan Kalori");
            }
        }

        private void EgzersizleriListele()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT EgzersizAdi, Sure, FORMAT(Tarih, 'dd.MM.yyyy') AS Tarih, KaloriYakit FROM EgzersizProgrami WHERE TcKimlikNo = @tc ORDER BY Tarih DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tc", tcKimlik);
                        SqlDataReader dr = cmd.ExecuteReader();
                        dgvEgzersizler.Rows.Clear();

                        while (dr.Read())
                        {
                            dgvEgzersizler.Rows.Add(dr["EgzersizAdi"], dr["Sure"], dr["Tarih"], dr["KaloriYakit"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EgzersizGrafikCiz()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT Tarih, SUM(Sure) AS ToplamSure FROM EgzersizProgrami WHERE TcKimlikNo = @tc " +
                                   "AND Tarih BETWEEN DATEADD(DAY, -7, GETDATE()) AND GETDATE() GROUP BY Tarih ORDER BY Tarih ASC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tc", tcKimlik);
                        SqlDataReader dr = cmd.ExecuteReader();

                        // **Seri var mı kontrol et, yoksa ekle**
                        if (!chartEgzersiz.Series.Contains(chartEgzersiz.Series.FindByName("EgzersizSuresi")))
                        {
                            chartEgzersiz.Series.Add("EgzersizSuresi");
                            chartEgzersiz.Series["EgzersizSuresi"].ChartType = SeriesChartType.Column;
                        }

                        chartEgzersiz.Series["EgzersizSuresi"].Points.Clear();

                        while (dr.Read())
                        {
                            DateTime tarih = Convert.ToDateTime(dr["Tarih"]);
                            int sure = Convert.ToInt32(dr["ToplamSure"]);

                            chartEgzersiz.Series["EgzersizSuresi"].Points.AddXY(tarih.ToShortDateString(), sure);
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
}

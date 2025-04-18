using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace KÜLTÜR_SAĞLIK_TAKİP_UYGULAMASI
{
    public partial class Raporlar : UserControl
    {
        private string tcKimlik;
        private string connectionString = "Server=DESKTOP-KT6O8E3\\SQLEXPRESS;Database=KulturSaglikDB;Trusted_Connection=True;";

        public Raporlar(string tcKimlik)
        {
            InitializeComponent();
            this.tcKimlik = tcKimlik;

            MessageBox.Show("Gönderilen TC Kimlik No: " + tcKimlik, "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            KullaniciBilgileriniGoster();
            TumVerileriGetir();
        }

        private void KullaniciBilgileriniGoster()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT AdSoyad, TcKimlikNo, DogumTarihi FROM Hastalar WHERE TcKimlikNo = @tc";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tc", tcKimlik);
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            lblKullaniciAdi.Text = dr["AdSoyad"].ToString();
                            lblTcKimlik.Text = dr["TcKimlikNo"].ToString();
                            lblDogumTarihi.Text = Convert.ToDateTime(dr["DogumTarihi"]).ToString("dd.MM.yyyy");
                        }
                        else
                        {
                            MessageBox.Show("Bu TC kimlik numarasına sahip hasta bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TumVerileriGetir()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                        SELECT 'Su Tüketimi' AS Kategori, Tarih, CAST(SuMiktari AS NVARCHAR) AS Detay FROM SuTuketimi WHERE TcKimlikNo = @tc
                        UNION ALL
                        SELECT 'Egzersiz Programı', Tarih, EgzersizAdi + ' - ' + CAST(Sure AS NVARCHAR) + ' dk' FROM EgzersizProgrami WHERE TcKimlikNo = @tc
                        UNION ALL
                        SELECT 'Sağlık Kayıtları', Tarih, 'Nabız: ' + CAST(Nabiz AS NVARCHAR) + ', Kilo: ' + CAST(Kilo AS NVARCHAR) + ' kg, Boy: ' + CAST(Boy AS NVARCHAR) FROM SaglikKayitlari WHERE TcKimlikNo = @tc
                        ORDER BY Tarih DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tc", tcKimlik);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvRaporlar.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tüm verileri çekerken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Kullanici_Raporu.pdf");

                if (File.Exists(filePath))
                {
                    try
                    {
                        File.Delete(filePath);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("PDF dosyası kullanımda. Lütfen kapatın ve tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                using (PdfWriter writer = new PdfWriter(filePath))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document document = new Document(pdf))
                {
                    PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                    PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                    document.Add(new Paragraph("📌 KÜLTÜR SAĞLIK TAKİP UYGULAMASI - KULLANICI RAPORU")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(boldFont)
                        .SetFontSize(16));

                    document.Add(new Paragraph("\n🔹 Kullanıcı Bilgileri").SetFont(boldFont));
                    KullaniciBilgileriniEkle(document, normalFont);

                    document.Add(new Paragraph("\n🔹 Tüm Kayıtlar").SetFont(boldFont));
                    TumVerileriEkle(document, normalFont);
                }

                MessageBox.Show("PDF Raporu başarıyla kaydedildi! Masaüstüne kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF oluşturulurken hata oluştu: " + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KullaniciBilgileriniEkle(Document document, PdfFont font)
        {
            try
            {
                document.Add(new Paragraph($"👤 Ad Soyad: {lblKullaniciAdi.Text}").SetFont(font));
                document.Add(new Paragraph($"📌 TC Kimlik No: {lblTcKimlik.Text}").SetFont(font));
                document.Add(new Paragraph($"🎂 Doğum Tarihi: {lblDogumTarihi.Text}").SetFont(font));
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF'e kullanıcı bilgileri eklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TumVerileriEkle(Document document, PdfFont font)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                SELECT 'Su Tüketimi' AS Kategori, Tarih, ISNULL(CAST(SuMiktari AS NVARCHAR), 'Bilinmiyor') AS Detay FROM SuTuketimi WHERE TcKimlikNo = @tc
                UNION ALL
                SELECT 'Egzersiz Programı', Tarih, ISNULL(EgzersizAdi + ' - ' + CAST(Sure AS NVARCHAR) + ' dk', 'Bilinmiyor') FROM EgzersizProgrami WHERE TcKimlikNo = @tc
                UNION ALL
                SELECT 'Sağlık Kayıtları', Tarih, ISNULL('Nabız: ' + CAST(Nabiz AS NVARCHAR) + ', Kilo: ' + CAST(Kilo AS NVARCHAR) + ' kg, Boy: ' + CAST(Boy AS NVARCHAR), 'Bilinmiyor') FROM SaglikKayitlari WHERE TcKimlikNo = @tc
                ORDER BY Tarih DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tc", tcKimlik);
                        SqlDataReader dr = cmd.ExecuteReader();

                        PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD); // Kalın font

                        Table table = new Table(new float[] { 3, 3, 5 }).UseAllAvailableWidth();
                        table.AddHeaderCell(new Cell().Add(new Paragraph("Kategori").SetFont(boldFont))); // Kalın font eklendi
                        table.AddHeaderCell(new Cell().Add(new Paragraph("Tarih").SetFont(boldFont)));    // Kalın font eklendi
                        table.AddHeaderCell(new Cell().Add(new Paragraph("Detay").SetFont(boldFont)));    // Kalın font eklendi

                        while (dr.Read())
                        {
                            table.AddCell(new Cell().Add(new Paragraph(dr["Kategori"].ToString()).SetFont(font)));
                            table.AddCell(new Cell().Add(new Paragraph(Convert.ToDateTime(dr["Tarih"]).ToString("dd.MM.yyyy")).SetFont(font)));
                            table.AddCell(new Cell().Add(new Paragraph(dr["Detay"].ToString()).SetFont(font)));
                        }
                        document.Add(table);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF'e veriler eklenirken hata oluştu: " + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

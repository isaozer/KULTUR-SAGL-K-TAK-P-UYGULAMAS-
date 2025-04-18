using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KÜLTÜR_SAĞLIK_TAKİP_UYGULAMASI
{
    public partial class FormSağlıkKaydı : UserControl
    {
        private string tcKimlik; // Kullanıcının TC Kimlik numarası
        private string connectionString = "Server=DESKTOP-KT6O8E3\\SQLEXPRESS;Database=KulturSaglikDB;Trusted_Connection=True;";

        public FormSağlıkKaydı(string tcKimlik)
        {
            InitializeComponent();
            this.tcKimlik = tcKimlik;
        }

        private void FormSağlıkKaydı_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tcKimlik))
            {
                SonSaglikKaydiniGetir(); // Son sağlık kaydını çek
                SuTuketimiGetir(); // Su tüketimi bilgisini çek
            }
            else
            {
                MessageBox.Show("HATA: Kullanıcı bilgisi alınamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool KullaniciSaglikKaydiVarMi()
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
                        int kayitSayisi = (int)cmd.ExecuteScalar();
                        return kayitSayisi > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sağlık kaydı kontrol edilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnYeniSaglikBilgisiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (KullaniciSaglikKaydiVarMi())
                {
                    MessageBox.Show("Zaten sağlık kaydınız var! Yeni bir kayıt ekleyemezsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // **Sadece Anasayfa.cs formunu kapat**
                Form anasayfa = Application.OpenForms["Anasayfa"];
                if (anasayfa != null)
                {
                    anasayfa.Invoke((MethodInvoker)(() => anasayfa.Close()));
                }

                // **Yeni sağlık kaydı formunu aç**
                SaglikKayit saglikKayitFormu = new SaglikKayit(tcKimlik);
                saglikKayitFormu.Show();

                // **Mevcut Formu Gizle**
                this.ParentForm?.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SonSaglikKaydiniGetir()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT TOP 1 KanBasinci, Nabiz, Kilo, Boy, Notlar FROM SaglikKayitlari WHERE TcKimlikNo = @tc ORDER BY Tarih DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tc", tcKimlik);
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            txtKanBasinci.Text = dr["KanBasinci"].ToString();
                            txtNabiz.Text = dr["Nabiz"].ToString();
                            txtKilo.Text = dr["Kilo"].ToString();
                            txtBoy.Text = dr["Boy"].ToString();
                            txtNotlar.Text = dr["Notlar"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Henüz sağlık kaydı bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuTuketimiGetir()
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
                            lblSuTuketimi.Text = "💧 Günlük Su Tüketimi: " + toplamSu.ToString() + " L";
                        }
                        else
                        {
                            lblSuTuketimi.Text = "💧 Henüz su tüketimi kaydı yok.";
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

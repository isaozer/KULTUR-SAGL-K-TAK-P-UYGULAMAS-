using System;
using System.Windows.Forms;

namespace KÜLTÜR_SAĞLIK_TAKİP_UYGULAMASI
{
    public partial class AnaSayfa : Form
    {
        private string kullaniciAdi;
        private string tcKimlik;

        public AnaSayfa(string kullaniciAdi, string tcKimlik)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;
            this.tcKimlik = tcKimlik; 
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("Bilgi: Kullanıcı Adı = [" + kullaniciAdi + "]\nTcKimlikNo = [" + tcKimlik + "]", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!string.IsNullOrEmpty(kullaniciAdi))
            {
                MessageBox.Show("Hoş Geldiniz, " + kullaniciAdi + "!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("HATA: Kullanıcı Adı Boş Geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            panelSaglikKayitlari.Controls.Clear();
            FormSağlıkKaydı saglikControl = new FormSağlıkKaydı(tcKimlik);

            // UserControl'ü panele ekleyelim
            saglikControl.Dock = DockStyle.Right;
            panelSaglikKayitlari.Controls.Add(saglikControl);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            {
                // Önce panelin içini temizleyelim
                panelSaglikKayitlari.Controls.Clear();
                sumiktari saglikControl = new sumiktari(tcKimlik);

                
                saglikControl.Dock = DockStyle.Right;
                panelSaglikKayitlari.Controls.Add(saglikControl);
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            panelSaglikKayitlari.Controls.Clear();
            EgzersizProgrami saglikControl = new EgzersizProgrami(tcKimlik);

            
            saglikControl.Dock = DockStyle.Right;
            panelSaglikKayitlari.Controls.Add(saglikControl);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butona tıklandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (string.IsNullOrWhiteSpace(tcKimlik))
            {
                MessageBox.Show("Kullanıcı kimliği bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            panelSaglikKayitlari.Controls.Clear();
            Raporlar raporControl = new Raporlar(tcKimlik);
            raporControl.Dock = DockStyle.Fill;
            panelSaglikKayitlari.Controls.Add(raporControl);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hesabınızdan çıkış yapmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart(); // Programı yeniden başlat (Kullanıcıyı login ekranına yönlendirir)
            }
        }

    }
}
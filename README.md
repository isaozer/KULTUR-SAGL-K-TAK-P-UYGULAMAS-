# 🎯 KÜLTÜR SAĞLIK TAKİP UYGULAMASI

Bu proje, bireylerin sağlık geçmişlerini dijital ortamda takip etmelerini kolaylaştırmak amacıyla geliştirilmiş bir **C# Windows Forms** uygulamasıdır. Hem **hastalar** hem de **personeller** için ayrı giriş ekranları sunarak kullanıcı rolleri arasında güvenli bir ayrım sağlar.

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji         | Açıklama                                      |
| ----------------- | --------------------------------------------- |
| 💻 C#             | Ana yazılım dili (Windows Forms UI)           |
| 🗃️ MS SQL Server | Veritabanı yönetimi ve veri saklama işlemleri |
| 🔐 ADO.NET        | Veritabanı bağlantı ve sorguları              |
| 🧹 WinForms       | Grafik arayüz tasarımı (UI)                   |

---

## 👤 Kullanıcı Rolleri

1. **Hasta Girişi**

   * TC Kimlik No ve şifreyle giriş yapılır
   * Başarılı giriş sonrası ad-soyad bilgisi alınarak **Ana Sayfa**'ya yönlendirme yapılır
   * Hasta, kendi bilgilerini görebilir

2. **Personel Girişi**

   * Kullanıcı adı (TC gibi) ve şifre girilir
   * Giriş sonrası **yetki seviyesi** kontrol edilir
   * Başarılı giriş sonrası personel ekranına geçilir

---

## 🎯 Projenin Hedefleri

* Sağlık sektöründe hasta ve çalışanların giriş yapabileceği bir **çok rollü sistem** geliştirmek
* TC Kimlik No ile kullanıcı doğrulama yaparak **güvenli bir oturum yönetimi** sağlamak
* Kullanıcı bilgilerini veritabanında saklayarak **kişiselleştirilmiş kullanıcı deneyimi** sunmak
* İleride:

  * Hasta verilerini görselleştirme
  * Sağlık geçmişi takibi
  * Personel işlem geçmişi kayıtları
  * Tema desteği / renk seçenekleri gibi özellikler eklemek

---

## 🔄 Geliştirme Aşamaları

| Aşama                     | Durum        |
| ------------------------- | ------------ |
| Kullanıcı giriş ekranı    | ✅ Tamamlandı |
| Veritabanı bağlantısı     | ✅ Tamamlandı |
| Hasta / Personel ayrımı   | ✅ Tamamlandı |
| Giriş sonrası yönlendirme | ✅ Tamamlandı |
| Hata kontrolleri          | ✅ Tamamlandı |
| Tema seçimi (hazırlık)    | 🔄 Planlandı |
| Sağlık geçmişi modülü     | 🔄 Planlandı |

---

## 📍 Nasıl Çalıştırılır?

1. Visual Studio'da projeyi aç
2. `app.config` veya `Form1.cs` içindeki `connectionString` kısmını kendi SQL Server bilgine göre düzenle
3. SQL Server'da `KulturSaglikDB` veritabanını oluştur ve gerekli tabloları ekle:

   * `Hastalar` tablosu (`TcKimlikNo`, `Sifre`, `AdSoyad`)
   * `Personeller` tablosu (`KullaniciAdi`, `Sifre`, `YetkiSeviyesi`)
4. Uygulamayı başlat (`F5`)

---

## 🤝 Katkıda Bulunmak İster misin?

Pull request’ler her zaman memnuniyetle karşılanır. Yeni özellik önerilerin veya hata bildirimlerin varsa **Issues** kısmına yazabilirsin.

---

## 🧠 Sonuç

Bu proje ile basit bir hasta ve personel takip sisteminin temelleri atılmış oldu. Yazılım geliştiriciliğine adım atmak isteyenler için gerçek bir senaryo üzerine geliştirilmiş işlevsel bir örnek teşkıl eder.

İleride yapılacak genişletmelerle birlikte bu sistemin daha profesyonel bir sağlık otomasyon sistemine dönüşmesi hedeflenmektedir.

---

> Geliştirici: **İsa Özer**

---

## 📷 Ekran Görüntüleri

### ▶️ Hasta Giriş Bölümü

* Giiriş Ekranı: ![Giriş](https://resmim.net/cdn/2025/05/04/NPNm4o.png)
* Kayıt Olma: ![Kayıt](https://resmim.net/cdn/2025/05/04/NPNDcW.png)
* Hasta Giriş: ![Hasta](https://resmim.net/cdn/2025/05/04/NPNX0K.png)
* Sağlık Kayıtları: ![Kayıtlar](https://resmim.net/cdn/2025/05/04/NPNCWQ.png)
* Yeni Kayıt Uyarısı: ![Uyarı](https://resmim.net/cdn/2025/05/04/NPNd27.png)
* Egzersiz Programı: ![Egzersiz](https://resmim.net/cdn/2025/05/04/NPNgcR.png)
* Egzersiz Ekleme: ![](https://resmim.net/cdn/2025/05/04/NPNYLy.png) ![](https://resmim.net/cdn/2025/05/04/NPNoYI.png)
* Su İçtim: ![Su](https://resmim.net/cdn/2025/05/04/NPN1l6.png)
* Su Verisi Ekleme: ![](https://resmim.net/cdn/2025/05/04/NPNRc2.png) ![](https://resmim.net/cdn/2025/05/04/NPN7LF.png)
* Raporlar: ![](https://resmim.net/cdn/2025/05/04/NPTMPn.png) ![](https://resmim.net/cdn/2025/05/04/NPTfeD.png) ![](https://resmim.net/cdn/2025/05/04/NPTDMb.png)
* Rapor PDF İndirme: ![](https://resmim.net/cdn/2025/05/04/NPTNgZ.png) ![](https://resmim.net/cdn/2025/05/04/NPTTt6.png)
* Güvenli Çıkış: ![](https://resmim.net/cdn/2025/05/04/NPNObC.png)

### ▶️ Personel Giriş Bölümü

* Giriş Ekranı: ![](https://resmim.net/cdn/2025/05/04/NPNVv1.png)
* Personel Paneli: ![](https://resmim.net/cdn/2025/05/04/NPNh7L.png)
* Hasta Bilgi Düzenleme: ![](https://resmim.net/cdn/2025/05/04/NPN9DM.png) ![](https://resmim.net/cdn/2025/05/04/NPNUtH.png)
* Çıkış: ![](https://resmim.net/cdn/2025/05/04/NPNv5j.png)

### 📊 Veritabanı

* SQL Tablolar: ![](https://resmim.net/cdn/2025/05/04/NPTdDF.png)

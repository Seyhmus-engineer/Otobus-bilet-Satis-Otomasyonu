# Otobüs Bilet Satış ve Rezervasyon Sistemi

Bu proje, C# ve WinForms kullanılarak geliştirilen, otobüs bileti satış ve rezervasyon işlemlerinin kolayca yapılmasını sağlayan bir masaüstü uygulamasıdır.

## Özellikler

- Otobüs seferi ekleme, güncelleme ve silme
- Koltuk rezervasyonu yapma ve iptal etme
- Şehirlerarası ve şehir içi otobüs işlemleri
- Müşteri ve kasa yönetimi
- Sefer, müşteri, otobüs ve kasa raporları
- Kullanıcı dostu Windows arayüzü

## Kullanılan Teknolojiler

- **C# (.NET Framework)**
- **WinForms** ile grafik arayüz
- **Entity Framework** ile veritabanı işlemleri
- **SQL Server** (veya LocalDB) veritabanı bağlantısı

## Kurulum ve Çalıştırma

1. **Projeyi İndir ve Aç:**
    - Proje klasörünü bilgisayarınıza indirin.
    - `OTobüs_BileT_Rezervasyon_SiTtemi.sln` dosyasını Visual Studio ile açın.

2. **Veritabanı Ayarları:**
    - Projede yer alan `Model1.edmx` dosyası üzerinden veritabanı bağlantı ayarlarını kontrol edin.
    - Gerekirse kendi SQL Server/LocalDB bağlantınızı `App.config` dosyasından düzenleyin.

3. **Projeyi Derle ve Çalıştır:**
    - Visual Studio’da projeyi derleyin (`F5` ile çalıştır).
    - Giriş formu üzerinden sisteme erişim sağlayın.

## Klasör Yapısı
OtobusBiletSatis/
│
├── OTobüs_BileT_Rezervasyon_SiTtemi.sln
└── OTobüs_BileT_Rezervasyon_SiTtemi/
├── Form1.cs, Form2.cs, ...
├── dbmusTeriTable.cs, dbseferTable.cs, ...
├── IRezervasyon.cs
├── Model1.edmx, Model1.Context.cs
├── Program.cs
└── ...

## Temel Sınıflar ve Yapılar

- **Form1.cs, Form2.cs, ...**: Uygulamanın ana arayüz formları
- **db...Table.cs**: Veritabanı model sınıfları
- **IRezervasyon.cs**: Rezervasyon işlemlerinin temel arayüzü (interface)
- **sehirlerarasi.cs / sehirici.cs**: Otobüs türleri için kalıtım uygulamaları

## Katkıda Bulunma

Katkıda bulunmak isterseniz, lütfen bir "pull request" gönderin veya "issue" açın.

## Lisans

Bu proje kişisel ve eğitim amaçlı olarak paylaşılmıştır. Geliştirici: [Şeyhmus Elik](https://github.com/Seyhmus-engineer)

---

**Not:** Uygulamayı çalıştırmadan önce veritabanı bağlantınızın doğru olduğundan emin olun.


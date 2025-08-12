## 📱 **Portfolio Project - ASP.NET Core 5.0**

Modern ve kapsamlı bir portföy yönetim sistemidir.  
Bu proje, ASP.NET Core 5.0 ile geliştirilmiş, N-Tier (Çok Katmanlı) mimariye sahip profesyonel bir web uygulamasıdır.  
Kullanıcıların, yazarların ve yöneticilerin farklı panellerde portföy yönetimi yapmasına olanak tanır.

- 📝 Kullanıcılar portföy, hakkımda, deneyim, yetenek ve referansları görüntüleyebilir.  
- 🔐 Yazarlar profil bilgilerini yönetebilir, mesajlaşabilir ve kişisel dashboard kullanabilir.  
- 🛠️ Admin portföy, deneyim, hizmet, referans, sosyal medya ve iletişim yönetimini gerçekleştirebilir.  
- 🌦️ Canlı hava durumu API’si entegrasyonu ile dinamik içerik sunar.  
- 🎨 Modern, responsive ve kullanıcı dostu arayüz.

---

## ⚙️ **Kullanılan Teknolojiler**

- 💻 Web uygulaması için **ASP.NET Core 5.0**  
- 🛠️ ORM aracı olarak **Entity Framework Core (Code First)**  
- 🔐 Kimlik doğrulama ve rol yönetimi için **ASP.NET Core Identity**  
- 📜 Form doğrulama ve iş kuralları için **FluentValidation**  
- 🌍 RESTful API desteği ve **Swagger (Swashbuckle)** ile dokümantasyon  
- 💾 Veritabanı olarak **Microsoft SQL Server**  
- 🎨 Responsive frontend için **Bootstrap 5**, **jQuery** ve **Font Awesome**  
- 📊 Veri görselleştirme için **Charts.js**  
- 🔄 Bağımlılık yönetimi için **Dependency Injection**  
- 🌐 Canlı hava durumu için **OpenWeather API** entegrasyonu  

---

## 🏗️ **Proje Yapısı**

Bu proje, **5 katmanlı mimari** prensiplerine göre yapılandırılmıştır. Her katman ilgili işlevselliği ve sorumlulukları taşır.

| Katman Adı               | Açıklama                                                     |
|--------------------------|--------------------------------------------------------------|
| **Entity Layer**         | Veritabanı tablolarının karşılığı olan entity sınıflarını içerir. |
| **Data Access Layer**    | EF Core implementasyonları, repository pattern uygulamaları. |
| **Business Layer**       | İş mantığı, servisler ve FluentValidation.       |
| **Presentation Layer**   | MVC tabanlı web arayüzü (Yazar, Admin, Public paneller).      |
| **API Layer**            | RESTful API servisleri ve Swagger dokümantasyonu.             |

---

## 👥 **Kullanıcı Panelleri**

| Panel         | Erişim             | Özellikler                                                                                  |
|---------------|--------------------|--------------------------------------------------------------------------------------------|
| **Public**    | Herkese açık       | Portföy, Hakkımda, Deneyim, Yetenekler, Hizmetler, Referanslar, İletişim formu              |
| **Writer**    | Kayıtlı kullanıcı  | Profil yönetimi, mesajlaşma, duyurular, kişisel dashboard                                  |
| **Admin**     | Yönetici rolü      | Portföy, deneyim, referans, iletişim, sosyal medya, hizmetler yönetimi                      |

---

## 🚀 **Öne Çıkan Özellikler**

- Çoklu kullanıcı ve rol bazlı erişim kontrolü  
- Güvenli kimlik doğrulama ve yetkilendirme  
- Katmanlı ve sürdürülebilir kod yapısı  
- Canlı hava durumu entegrasyonu (OpenWeather API)  
- Gelişmiş mesajlaşma sistemi  
- Swagger ile API dokümantasyonu  
- 401 ve 404 hata sayfaları ile kullanıcı deneyimi iyileştirme  
- Dosya yükleme ve grafik gösterimleri (Charts.js)  

---


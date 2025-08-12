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

<img width="1920" height="6208" alt="Image" src="https://github.com/user-attachments/assets/b58e4e18-a7cf-4aca-9846-af7e6a8f19f3" />
<img width="1920" height="1053" alt="Image" src="https://github.com/user-attachments/assets/ea964c09-74fe-46bf-b171-5baee1142472" />
<img width="1920" height="1301" alt="Image" src="https://github.com/user-attachments/assets/f62ea4b2-635c-426b-b9d9-a270df35d118" />
<img width="1920" height="1016" alt="Image" src="https://github.com/user-attachments/assets/9cd07d0d-3f91-4318-b8e4-f4c39d67c396" />
<img width="1920" height="1820" alt="Image" src="https://github.com/user-attachments/assets/1e66d2d9-3e8f-40ab-b68f-4e740ae2f54c" />
<img width="1920" height="1674" alt="Image" src="https://github.com/user-attachments/assets/ec8bf066-88bb-4697-8056-104a9a5bc206" />
<img width="1920" height="1408" alt="Image" src="https://github.com/user-attachments/assets/4c0ddb10-dab3-4ce5-b8ec-02c1c19c5500" />

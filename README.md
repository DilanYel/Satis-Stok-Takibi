# 📦 Satış ve Stok Takip Sistemi

Bu proje, küçük ve orta ölçekli işletmelerin ürün, stok ve satış işlemlerini kolayca yönetebilmesi amacıyla geliştirilmiş bir **C# WinForms masaüstü uygulamasıdır**.  
Uygulama **N Katmanlı Mimari** yapısına uygun olarak tasarlanmış ve **MySQL** veritabanı kullanılmıştır.

---

## 🎯 Projenin Amacı

- Ürün ve stok takibini düzenli bir şekilde yapmak  
- Satış işlemlerini kayıt altına almak  
- Kullanıcı rollerine göre yetkilendirme sağlamak  
- Aylık ve günlük raporlar ile işletme performansını analiz etmek  
- N katmanlı mimari ve OOP kavramlarını uygulamalı olarak öğrenmek  

---
## 📌 Proje Özellikleri

- Kullanıcı girişi ve rol bazlı yetkilendirme  
- Ürün ekleme, silme ve güncelleme işlemleri  
- Stok takibi ve otomatik stok güncelleme  
- Minimum stok uyarı sistemi  
- Müşteri yönetimi  
- Satış işlemleri ve satış kayıtları  
- Günlük ve aylık raporlamalar
  
---
## 👥 Kullanıcı Rolleri

Uygulamada üç farklı kullanıcı rolü bulunmaktadır:

- **Yönetici**
  - Tüm işlemleri yapabilir
  - Raporları görüntüler
  - Ürün, müşteri ve satış yönetimini sağlar

- **Satış Personeli**
  - Satış işlemleri yapar
  - Ürün ve müşteri listesini görüntüler

- **Depo Görevlisi**
  - Ürün ekleme ve güncelleme
  

---

## 🏗️ N Katmanlı Mimari Yapısı

Proje üç ana katmandan oluşmaktadır:

### 🔹 Veri Erişim Katmanı (DAL)
- MySQL bağlantıları bu katmanda kurulur  
- SQL sorguları burada yazılır  
- Veritabanı işlemleri UI katmanından tamamen ayrılmıştır  

### 🔹 İş Katmanı (BLL)
- İş kuralları bu katmanda yer alır  
- Örnek kurallar:
  - Stok miktarı 0’ın altına düşemez
  - Satış yapılırken stok kontrolü yapılır  
- UI ile DAL arasında köprü görevi görür  

### 🔹 Sunum Katmanı (UI)
- WinForms arayüzleri bu katmandadır  
- Kullanıcı etkileşimleri burada gerçekleşir  
- Formlar, butonlar ve tablolar bu katmanda bulunur  

---

## 🖥️ Uygulama Ekranları

- **Giriş Ekranı (LoginForm)**
  - Kullanıcı adı ve şifre ile giriş yapılır
  - Kullanıcı rolüne göre yetkilendirme sağlanır

- **Ürün Yönetimi**
  - Ürün ekleme, silme ve güncelleme
  - Minimum stok uyarıları

- **Müşteri Yönetimi**
  - Müşteri ekleme ve listeleme
  - Bireysel / Gel-Al müşteri türü seçimi

- **Satış Ekranı**
  - Müşteri seçimi
  - Ürün ekleme ve miktar girme
  - Satış sonrası stok düşme işlemi

- **Raporlama Ekranı**
  - Aylık satış raporu
  - Toplam ciro
  - Satış adedi
  - Kâr / zarar hesaplamaları
  - Minimum stok raporu

---

## 📊 Raporlama Özellikleri

- 📅 Aylık satış raporu  
- 💰 Toplam ciro  
- 📈 Satış adedi  
- 📦 En çok satılan ürünler  
- ⚠️ Minimum stok uyarıları  

---

## 🧱 Kullanılan Teknolojiler

- C#
- WinForms
- MySQL
- N Katmanlı Mimari
- Nesne Yönelimli Programlama (OOP)

---
## 📞 İletişim

Herhangi bir sorunuz veya öneriniz varsa lütfen benimle iletişime geçin:

- **Ad:** Dilan  
- **Soyad:** Yel  
- **Telefon:** +90 544 940 48 05
- **E-posta:** dilanyel00@gmail.com  
---
## Youtube

https://youtu.be/niioUbZcVuY?si=8QFnA2YB10AxVINf

---

## 📌 Not

Bu proje, eğitim amaçlı olarak geliştirilmiştir ve **N katmanlı mimari**, **veritabanı kullanımı** ve **OOP prensiplerini** pekiştirmeyi amaçlamaktadır.

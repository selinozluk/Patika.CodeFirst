# Patika Code First Basic

Bu proje, **Entity Framework Core Code First** yaklaşımıyla basit bir veritabanı oluşturmayı amaçlamaktadır.  
Veritabanında iki tablo yer almaktadır: **Movies** ve **Games**.

---

## Özellikler
- **Movie** tablosu:
  - `Id` (int) → Primary Key, otomatik artan
  - `Title` (string) → Filmin başlığı
  - `Genre` (string) → Tür (ör: Action, Comedy, Drama)
  - `ReleaseYear` (int) → Çıkış yılı

- **Game** tablosu:
  - `Id` (int) → Primary Key, otomatik artan
  - `Name` (string) → Oyunun adı
  - `Platform` (string) → Platform (ör: PC, PlayStation, Xbox)
  - `Rating` (decimal(3,1)) → Puan (0–10 arası)

---

## Kullanılan Teknolojiler
- .NET 8.0
- Entity Framework Core 8.0
- SQL Server (LocalDB)
- C#

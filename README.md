# Windows Form Veri Tabanı Uygulaması

Bu proje, **Windows Forms** kullanılarak geliştirilmiş bir uygulamadır ve temel amacı **veri tabanında kayıt ekleme, güncelleme ve silme işlemlerini** gerçekleştirmektir.

## Özellikler

* Veri tabanına **yeni kayıt ekleme**
* Var olan kayıtları **güncelleme**
* Kayıtları **silme**
* Basit ve kullanıcı dostu arayüz

## Gereksinimler

* Visual Studio (2019 veya daha yeni sürüm önerilir)
* .NET Framework
* SQL Server veya uygun bir veri tabanı sunucusu

## Kurulum

1. Projeyi GitHub’dan klonlayın:

   ```bash
   git clone https://github.com/kullaniciadi/projeadi.git
   ```
2. Visual Studio ile projeyi açın.
3. `App.config` veya proje ayarları üzerinden **veri tabanı bağlantı stringinizi** güncelleyin.
4. Projeyi çalıştırın ve arayüz üzerinden kayıt ekleme, güncelleme ve silme işlemlerini gerçekleştirin.

## Bağlantı String Örneği

```csharp
string connectionString = "Server=localhost\\SQLEXPRESS;Database=VeritabaniAdi;Trusted_Connection=True;";
```

## Kullanım

1. Uygulamayı çalıştırın.
2. Kayıt eklemek için ilgili formu kullanın.
3. Kayıt güncellemek için listeden seçip düzenleyin.
4. Kayıt silmek için listeden seçip silme butonunu kullanın.

## Katkıda Bulunma

Projeye katkıda bulunmak isterseniz, **fork** yapabilir ve ardından **pull request** gönderebilirsiniz.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır.

---


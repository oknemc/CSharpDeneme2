using OOP2;

//Okan
GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "Okan";
musteri1.TcNo = "23234235442";

//Alcatraz.Co

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "23423";
musteri2.SirketAdi = "Alcatraz";
musteri2.VergiNo = "32432532423";


// Gerçek Müşteri - Tüzel Müşteri
// SOLID
Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

// new gördüğün yerde bellekte ref no olarak gör
// eğer base sınıfın varsa o base sınıf referans tutucudur!!

MusteriManager musteriManager = new MusteriManager();
musteriManager.Add(musteri1);
musteriManager.Add(musteri2);
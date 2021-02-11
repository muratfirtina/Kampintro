using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Murat Fırtına
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Murat";
            musteri1.Soyadi = "Fırtına";
            musteri1.TcNo = "12345678910";


            //Fırtına AŞ
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Fırtına A.Ş";
            musteri2.VergiNo = "123456789";


            //Gerçek Müşteri - Tüzel Müşteri

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);


        }
    }
}

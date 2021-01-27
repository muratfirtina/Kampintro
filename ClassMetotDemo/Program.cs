using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 20211;
            musteri1.Adi = "Emel";
            musteri1.Soyadi = "Fırtına";
            musteri1.TcKimlikNo = "12345678902";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 20212;
            musteri2.Adi = "Murat";
            musteri2.Soyadi = "Fırtına";
            musteri2.TcKimlikNo = "12345678904";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 20213;
            musteri3.Adi = "Vera";
            musteri3.Soyadi = "Fırtına";
            musteri3.TcKimlikNo = "12345678906";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 20214;
            musteri4.Adi = "Pekmez";
            musteri4.Soyadi = "Fırtına";
            musteri4.TcKimlikNo = "12345678908";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Guncelle(musteri3);
            musteriManager.Sil(musteri4);





        }
    }
}

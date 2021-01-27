using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + "isimli müşteri eklendi!");
            Console.WriteLine("---------------------------------------");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + "isimli müşteri silindi!");
            Console.WriteLine("---------------------------------------");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Müşteri Bigileri Listeleniyor");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Musteri Id : " + musteri.Id + "\n" + "Musteri Adı : " + musteri.Adi
                + "\n" + "Musteri Soyadı : " + musteri.Soyadi + "\n" + "Musteri TC Kimlik No : " + musteri.TcKimlikNo);


        }

        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + "Bilgileriniz güncellenmiştir!");
            Console.WriteLine("---------------------------------------");
        }

    }
}

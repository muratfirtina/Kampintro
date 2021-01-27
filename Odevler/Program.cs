using System;

namespace Odevler
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunMarkasi = "Apple";
            urun1.urunAdi = "Iphone 12";
            urun1.urunRengi = "Space Gray";
            urun1.urunFiyatı = 12000;

            Urun urun2 = new Urun();
            urun2.urunMarkasi = "Samsung";
            urun2.urunAdi = "Galaxy S21";
            urun2.urunRengi = "Green";
            urun2.urunFiyatı = 8000;

            Urun urun3 = new Urun();
            urun3.urunMarkasi = "Huawei";
            urun3.urunAdi = "Mate 20";
            urun3.urunRengi = "Blue";
            urun3.urunFiyatı = 7000;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            Console.WriteLine("For Dögüsü");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunMarkasi + " : " + urunler[i].urunAdi);
            }

            Console.WriteLine("Foreach Dögüsü");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunMarkasi + " : " + urun.urunAdi);
            }

            Console.WriteLine("While Döngüsü");

            int counter = 0;
            while (counter < urunler.Length)
            {
                Console.Write(urunler[counter].urunMarkasi + "  :  ");
                Console.Write(urunler[counter].urunAdi);
                Console.WriteLine("");
                counter++;
            }


        }

    }
    class Urun
    {
        public string urunAdi { get; set; }
        public int urunFiyatı { get; set; }
        public string urunRengi{ get; set; }
        public string urunMarkasi { get; set; }

    }
}

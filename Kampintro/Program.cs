using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            bool sistemeGirisYapismi = true;

            if (sistemeGirisYapismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

        }
    }
}

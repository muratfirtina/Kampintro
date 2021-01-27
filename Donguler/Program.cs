using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string kurs1 = "Yazılım Geliştirme Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            //array = dizi



            string[] kurslar = new string[] { "Yazılım Geliştirme Yetiştirme Kampı" , "Programlamaya başlangıç için temel kurs" , "Java" , "Python" };




            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");


            int number = 1;
            switch (number)
            {
                case 1:
                    Console.WriteLine("Durum 1");
                    break;
                case 2:
                    Console.WriteLine("Durum 2");
                    break;
                default:
                    Console.WriteLine("Varsayılan durum");
                    break;
            }


            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Şimdi haftasonu dinlen biraz.");
                    break;
                default:
                    Console.WriteLine("Haftaiçi şimdi çalışma zamanı");
                    break;
            }
        }
    }
}

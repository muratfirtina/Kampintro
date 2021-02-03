using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(34, "İstanbul");
            myDictionary.Add(52, "Ordu");

            Console.WriteLine("Şehirler : ");
            for (int i = 0; i < myDictionary.Lenght; i++)
            {
                Console.WriteLine("Plaka Kodu:" + myDictionary.Keys[i] + " \n " + "Şehir Adı :" + " " + myDictionary.Values[i]);
            }
        }
    }
}

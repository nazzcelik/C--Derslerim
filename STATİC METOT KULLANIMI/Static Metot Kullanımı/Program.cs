using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetotKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static Metot Kullanımı
            // STATİC ANAHTAR KELİMESİNİ KULLANDIĞIMIZ ZAMAN METODA ERİŞMEK İÇİN OBJE OLUŞTURMAMIZA GEREK KALMAZ, CLASS İSMİ ÜZERİNDEN ERİŞEBİLİRİZ.

            stajyer.isimSoyisimYazdir();
            stajyer.sayilariTopla(20, 12, 3);
            stajyer S1 = new stajyer();
            S1.sayilariCarp(5, 6);

            Console.ReadLine();
        }
    }
}

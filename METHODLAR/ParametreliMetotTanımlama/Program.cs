using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreliMetotTanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parametre alan - Geriye değer döndürmeyen metot yazma...
            toplamaYap(5, 10);
            Console.WriteLine("");
            carpmaYap(2,3,5);
            Console.WriteLine("");
            isimSoyisimYazdir("Naz", "ÇELİK");
            Console.ReadLine();
        }

        static void toplamaYap(int sayi1, int sayi2)
        {
            Console.WriteLine("İki Sayının Toplamı : "+(sayi1 + sayi2));
        }

        static void carpmaYap(int sayi1, int sayi2, int sayi3)
        {
            Console.WriteLine("Üç Sayının Çarpımı : "+(sayi1*sayi2*sayi3));
        }

        static void isimSoyisimYazdir(string isim, string soyisim)
        {
            Console.WriteLine("Lütfen İsminizi ve Soyisminizi Giriniz : "+(isim+" "+soyisim));
        }



    }
}

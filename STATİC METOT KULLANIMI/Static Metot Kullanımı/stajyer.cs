using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetotKullanimi
{
    public class stajyer
    {
        public static void isimSoyisimYazdir()
        {
            Console.WriteLine("Naz ÇELİK");
        }
        public static void sayilariTopla(int sayi1, int sayi2, int sayi3)
        {
            int toplam = (sayi1 + sayi2 + sayi3);
            Console.WriteLine("Üç Sayının Toplamı: " + toplam);
        }
        public void sayilariCarp(int sayi1, int sayi2)
        {
            int carpim = (sayi1 * sayi2);
            Console.WriteLine("İki Sayının Çarpımı: " + carpim);
        }
    }
}

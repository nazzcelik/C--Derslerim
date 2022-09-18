using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeriyeDegerDöndürenMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parametre alan - Geriye değer döndüren metot tanımlama.
            // return anahtar kelimesi
            int donenDeger= toplamaYap(4, 5, 6);
            Console.WriteLine("Üç Sayının Toplam Değeri : " + (donenDeger));

            if (donenDeger>10)
            {
                Console.WriteLine("Toplam Değer 10'dan Büyüktür...");
            }
            else
            {
                Console.WriteLine("Toplam Değer 10'dan Küçüktür...");
            }

            string gelenİsimSoyisimDegeri =isimSoyisimYazdir("Naz", "Çelik");
            Console.WriteLine(gelenİsimSoyisimDegeri);

            Console.ReadLine();


        }

        static int toplamaYap(int a, int b, int c)
        {
            int sonuc = (a + b + c);
            return sonuc;
        }

        static string isimSoyisimYazdir(string isim, string soyisim)
        {
            return isim + " " + soyisim;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedenKitleİndeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Beden Kitle İndeksi = Kilo/ Boy * Boy
            // Beden Kİtle İndeksi 18'e Eşit veya Düşükse ZAYIF
            // 18-25 arasındaysa NORMAL
            // 25'ten Büyükse OBEZ Yazdıran Programı Kodlayınız...

            Console.WriteLine("Lütfen Kilonuzu Giriniz :");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen Boyunuzu Giriniz :");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if (bke <= 18)
            {
                Console.WriteLine("Beden Kitle Endeksiniz :" + bke);
                Console.WriteLine("Sonuç : ZAYIF");
                Console.ReadLine();
            }

            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("Beden Kitle Endeksiniz :" + bke);
                Console.WriteLine("Sonuç : NORMAL");
                Console.ReadLine();
            }

            else if (bke > 25)
            {
                Console.WriteLine("Beden Kitle Endeksiniz :"+bke);
                Console.WriteLine("Sonuc : OBEZ");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ!");
                Console.ReadLine();
            }

            
        }
    }
}

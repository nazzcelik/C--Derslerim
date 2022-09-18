using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enumerations (Numaralandırmalar) anlamına gelir. Eğer 1 derse şunu yap, 2 derse şunu yap dediğimiz yerlerde kullanacağız.
            // Enum içerisinde değer vermezsek 0'dan başlar ve birer birer artar.



            Gunler gun = Gunler.pazar;

            if(gun==Gunler.pazartesi)
            {
                Console.WriteLine("Gün, Pazartesidir.");
            }
            else if(gun==Gunler.sali)
            {
                Console.WriteLine("Gün, Salıdır.");
            }
            else if (gun == Gunler.carsamba)
            {
                Console.WriteLine("Gün, Çarşambadır.");
            }
            else if (gun == Gunler.persembe)
            {
                Console.WriteLine("Gün, Perşembedir.");
            }
            else if (gun == Gunler.cuma)
            {
                Console.WriteLine("Gün, Cumadır.");
            }
            else if (gun == Gunler.cumartesi)
            {
                Console.WriteLine("Gün, Cumartesidir.");
            }
            else if (gun == Gunler.pazar)
            {
                Console.WriteLine("Gün, Pazardır.");
            }
            else
            {
                Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ!");
            }
            Console.ReadLine();

        }
    }
}

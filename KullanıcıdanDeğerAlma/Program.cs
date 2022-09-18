using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanDegerAlma_
{
    class Program
    {
        static void Main(string[] args)
        {
            //readline fonksiyonu ile kullanıcıdan değer alıyoruz
            Console.WriteLine("Lütfen Adınızı Giriniz");
            string isim = Console.ReadLine();

            Console.WriteLine("Lütfen Soyisminizi yazınız");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Kullanıcının İsmi:"+isim);
            Console.WriteLine("Kullanıcının Soyismi:"+soyisim);

            Console.ReadLine();
        
        }
    }
}

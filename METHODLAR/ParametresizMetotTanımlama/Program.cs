using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parametresiz, geriye değer döndürmeyen (VOİD) method tanımlama
            SelamVer();
            Console.WriteLine("*******************");
            Console.WriteLine("");
            KullaniciBilgileri();
            Console.WriteLine("==========================");
            iletisim();

        }

        static void SelamVer()
        {
            Console.WriteLine("Selamlar :) ");
        }

        static void KullaniciBilgileri()
        {
            int KullaniciID = 123456;
            string isim = "Naz";
            string soyisim = "Çelik";
            int Yas = 19;
            string cinsiyet = "Kadın";

            Console.WriteLine("KULLANICI BİLGİLERİ : ");
            Console.WriteLine("");
            Console.WriteLine("Kullanıcı ID : "+KullaniciID);
            Console.WriteLine("Kullanıcı İsim : "+isim);
            Console.WriteLine("Kullanıcı Soyisim : "+soyisim);
            Console.WriteLine("Kullanıcı Yaşı : "+Yas);
            Console.WriteLine("Kullanıcı Cinsiyet : "+cinsiyet);
        }

        static void iletisim()
        {
            Console.WriteLine("naz@nazzcelik.com");
            Console.ReadLine();
        }
    }
}

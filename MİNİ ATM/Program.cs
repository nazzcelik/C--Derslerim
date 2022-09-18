using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya Hangi İşlemi Yapmak İstediğini SOracağız 
            // 1-Bakiye Sorgulama
            // 2-Para Çekme
            // 3-Para Yatırma
            // q'ya basarsa Çıkış yapılacak


            int bakiye = 1000;

            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz :");
            Console.WriteLine("1 : Bakiye Sorgulama");
            Console.WriteLine("2 : Para Çekme");
            Console.WriteLine("3 : Para Yatırma");
            Console.WriteLine("q : Çıkış Yapmak");

            string secim = Console.ReadLine();


            if (secim == "1")
            {
                Console.WriteLine("Mevcut Bakiyeniz :" + bakiye);
                Console.ReadLine();
            }

            else if (secim == "2")
            {
                Console.WriteLine("LÜtfen Çekmek İstediğiniz Tutarı giriniz :");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                if (cekilecek_tutar < bakiye)
                {
                    Console.WriteLine("Lütfen Paranızı Alınız");

                    Console.WriteLine("Kalan Bakiyeniz :" + (bakiye - cekilecek_tutar));

                    Console.WriteLine("TEŞEKKÜRLER :)");
                    Console.ReadLine();
                }

                else if (cekilecek_tutar >= bakiye)

                {
                    Console.WriteLine("YETERSİZ BAKİYE! ");
                    Console.ReadLine();
                }
            }


            else if (secim == "3")

            {
                Console.WriteLine("Lütfen Yatırmak İstediğiniz Miktarı Giriniz :");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Paranız Yatırılmıştır.");
                Console.WriteLine(" KARTINIZI ALINIZ!");
                Console.ReadLine();
            }

            else if (secim == "q")

            {
                Console.WriteLine("ÇIKIŞ YAPILDI");
                Console.WriteLine("TEŞEKKÜRLER");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz...");
                Console.ReadLine();
            }
        
            
        }
    }
}

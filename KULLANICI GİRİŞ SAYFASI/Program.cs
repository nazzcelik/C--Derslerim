using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciGirişSayfasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanici Giriş Sayfası Örneği
            // Kullanıcı, Kullanıcı Adını ve Şifresini Dogru Girerse "TEBRİKLER! GİRİŞ BAŞARILI." Desin
            // Yanlış Girerse Hata verelim ve 3 Hak Tanıyalım, Yanlış Girdiği Sürece Döngü Devam Etsin.

            int allahin_hakki = 3;

            while (true)
            {
                Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz :");
                string KullaniciAdi = Console.ReadLine();

                Console.WriteLine("Lütfen Şifrenizi Girniz :");
                string sifre= Console.ReadLine();

                if (KullaniciAdi == "nazzcelik" && sifre == "123")
                {
                    Console.WriteLine("GİRİŞ YAPILIYOR...");
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen Kullanıcı Adınızı veya Şifrenizi Kontrol Edip TEKRAR DENEYİNİZ!");

                    if (allahin_hakki > 0)
                    {
                        allahin_hakki -= 1;
                    }

                    if (allahin_hakki == 0)
                    {
                        Console.WriteLine("Çok Sayıda Hatalı Deneme Yaptınız, Lütfen DAHA SONRA TEKRAR DENEYİNİZ!!");
                        break;
                    }
                }

            }
            Console.ReadLine();



        }
    }
}

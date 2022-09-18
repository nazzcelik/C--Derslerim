using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mini ATM Uygulaması yap (Switch-Case) kullanarak.
            // 1-Bakiye Görüntüleme
            // 2-Para Çek
            // 3-Para Yatır
            // 4-Çıkış Yap

            int Bakiye = 950;

            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz");
            Console.WriteLine("1- Bakiye Sorgulama");
            Console.WriteLine("2- Para Çekme");
            Console.WriteLine("3- Para Yatırma");
            Console.WriteLine("4- Çıkış Yapma");

            string sonuc = Console.ReadLine();

            switch (sonuc)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz :" + Bakiye);
                    Console.ReadLine();
                    break;


                case "2":

                    Console.WriteLine("Lütfen Çekmek İstediğiniz Tutarı giriniz :");
                    int Cekilen_tutar = Convert.ToInt32(Console.ReadLine());

                    if (Cekilen_tutar > Bakiye)
                    {
                        Console.WriteLine("YETERSİZ BAKİYE");
                        Console.ReadLine();
                    }

                    else 
                    {
                        Console.WriteLine("İşleminiz Gerçekleşmiştir...");
                        Console.WriteLine("Kalan Bakiyeniz :" + (Bakiye - Cekilen_tutar));
                        Console.ReadLine();
                    }
                    break;
                    

                case "3":

                    Console.WriteLine("Lütfen Yatırmak İstediğiniz Turarı Giriniz..");
                    int yatrln_para = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("İşleminiz Grçekleşmiştir...");
                    Console.WriteLine("Yeni Bakiyeniz :" + (Bakiye + yatrln_para));
                    Console.ReadLine();
                    break;

                case "4":

                    Console.WriteLine("İşleminiz Sona Ermiştir, Çıkış Yapılıyor...");
                    Console.WriteLine("TEŞEKKÜRLER :)");
                    Console.ReadLine();
                    break;

                default:

                    Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ!");
                    Console.ReadLine();
                    break;


            }

            




        }
    }
}

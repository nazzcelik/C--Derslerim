using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci Ogrenci1 = new Ogrenci(490,"Naz","ÇELİK", 80, 65, 90, "Sakarya Üniversitesi");
            bool kontrol = true;
            

            while (kontrol)
            {
                Console.WriteLine("*************************");
                islemleriGoster();

                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        Ogrenci1.OgrenciBilgileriGoster();
                        break;

                    case "2":
                        double ogr_ort = Ogrenci1.OgrenciOrtalamasiBul();
                        Console.WriteLine("Öğrenci Not Ortalaması : "+ogr_ort);
                        break;

                    case "3":
                        Ogrenci1.OkulGetir();
                        break;

                    case "4":
                        kontrol = false;
                        break;
                }
                
            }


        }
        static void islemleriGoster()
        {
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz : ");
            Console.WriteLine("===========================================");
            Console.WriteLine("1) Öğrenci Bilgileri Göster.");
            Console.WriteLine("2) Öğrenci Ortalaması Göster.");
            Console.WriteLine("3) Öğrencini Okuduğu Okulun Adını Göster.");
            Console.WriteLine("4) Sayfadan Çıkış Yap.");
        }
    }
}

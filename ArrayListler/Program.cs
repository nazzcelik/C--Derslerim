using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diziyi Tanımlama:
            ArrayList liste = new ArrayList();

            // Diziye Veri Ekleme: 
            liste.Add("Sakarya");
            liste.Add('N');
            liste.Add("Ağrı");
            liste.Add(34);
            Console.WriteLine("Lütfen İsminizi Giriniz: ");
            Console.WriteLine("*************************");

            // Dizi Elemanını Kullanıcıdan Alma:
            string isim = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("LİSTENİZ: ");
            Console.WriteLine("---------");
            liste.Add(isim);
            foreach (var x in liste)
            {
                Console.WriteLine(x);
            }

            // Dizide Index Numarasına Göre Veri Ekleme:
            liste.Insert(1, 19);
            Console.WriteLine("-------------------------");
            Console.WriteLine("INSERT METOTUNDAN SONRA...");
            foreach (var x in liste)
            {
                Console.WriteLine(x);
            }

            // Diziden Veri Silme:
            liste.Remove("Sakarya");
            Console.WriteLine("-------------------------");
            Console.WriteLine("REMOVE METOTUNDAN SONRA...");
            foreach (var a in liste)
            {
                Console.WriteLine(a);
            }

            // Index Numarasına Göre Veri Silme
            liste.RemoveAt(4);
            Console.WriteLine("-------------------------");
            Console.WriteLine("RemoveAt METOTUNDAN SONRA...");
            foreach (var x in liste)
            {
                Console.WriteLine(x);
            }

            // Bir Değer Dizide Var mı Yok mu Kontrol Etme
            bool Kontrol = liste.Contains(34);
            Console.WriteLine("----------------------------");
            Console.WriteLine("CONTAİNS METOTUNDAN SONRA...");
            foreach (var x in liste)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Girilen Değer Dizide Var mı? : " + Kontrol);
            Console.WriteLine("***************************");

            // Dizinin Kapasitesini ve Eleman Sayısını Gösterme
            Console.WriteLine("Kapasite: " + liste.Capacity);
            Console.WriteLine("Eleman Sayısı: " + liste.Count);


            Console.ReadLine();



        }
    }
}

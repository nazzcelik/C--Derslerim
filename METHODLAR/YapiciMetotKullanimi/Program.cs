using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetotKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            int okul_adi;
            string bina_rengi;
            int sinif_sayisi;
            int sira_sayisi;

            Okul okul1 = new Okul("Sakarya Üniversitesi",120,2000,"Mavi");

            Console.WriteLine("Okul adı : "+okul1.okul_adi);
            Console.WriteLine("Bina Rengi : "+okul1.bina_rengi);
            Console.WriteLine("Sınıf sayısı : "+okul1.sinif_sayisi);
            Console.WriteLine("Sıra Sayısı : "+okul1.sira_sayisi);

            //okul1.okul_adi = "Sakarya Üniversitesi";
            //okul1.bina_rengi = "Mavi";
            //okul1.sinif_sayisi = 120;
            //okul1.sıra_sayisi = 5000;

            //Console.WriteLine("Okul Adı : "+okul1.okul_adi);
            //Console.WriteLine("Bina rengi : "+okul1.bina_rengi);
            //Console.WriteLine("Sınıf sayısı : "+okul1.sinif_sayisi);
            //Console.WriteLine("Sıra sayısı : "+okul1.sira_sayisi);

            Console.ReadLine();
        }
    }
}

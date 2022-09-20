using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Ogrenci> repositoryOgrenci = new Repository<Ogrenci>();
            List<Ogrenci> ogrencilerim = repositoryOgrenci.Getir();

            Ogrenci ogr = new Ogrenci();
            ogr.ID = 4815162342;
            ogr.isim = "Naz";
            ogr.soyad = "Çelik";
            ogr.cinsiyet = "Kadın";
            repositoryOgrenci.ekle(ogr);

            Repository<Ders> repositoryDers = new Repository<Ders>();
            List<Ders> Derslerim = repositoryDers.Getir();

            Ders ders = new Ders();
            ders.DersID = 4815162342;
            ders.DersIsim = "Algoritma";
            ders.DersSaati = 3;
            string cikti = repositoryDers.ekle(ders);

            Console.WriteLine(cikti);
            Console.ReadLine();

        }
    }
}

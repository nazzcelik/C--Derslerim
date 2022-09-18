 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogr = new ogrenci();

            ogr.AD = "Naz";
            ogr.SOYAD = "ÇELİK";
            ogr.YAS = 14;
            ogr.ALAN = "Türkçe-Matematik";

            Console.WriteLine("Ad: "+ogr.AD);
            Console.WriteLine("Soyad: "+ogr.SOYAD);
            Console.WriteLine("Yaş: "+ogr.YAS);
            Console.WriteLine("Alan: "+ogr.ALAN);

            Console.ReadLine();
        }
    }
}

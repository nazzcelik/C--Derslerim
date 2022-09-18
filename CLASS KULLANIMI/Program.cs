using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();

            araba1.arabaModeli = "Renault";
            araba1.arabaRengi = "Siyah";
            araba1.kapiSayisi = 4;

            Console.WriteLine("Araba Modeli : " + araba1.arabaModeli);
            Console.WriteLine("Araba Rengi : " + araba1.arabaRengi);
            Console.WriteLine("Kapı Sayısı:" + araba1.kapiSayisi);
            Console.WriteLine(" ");
            Console.WriteLine("====================================");
            Console.WriteLine(" ");

            araba1.KapilariKilitle();
            araba1.MotoruCalistir();

            

            Console.ReadLine();
        }
    }
}

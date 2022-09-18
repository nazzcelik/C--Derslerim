using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDegiskenKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan C1 = new Calisan();

            C1.calisanID = 12345;
            C1.isim = "Rüya";
            C1.soyisim = "Hayal";
            Calisan.maas = 5700;

            C1.yazdir();

            Console.ReadLine();
            
        }
    }
}

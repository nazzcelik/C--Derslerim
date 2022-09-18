using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslarArasiInheritance
{
    class Program
    {
        static void Main(string[] args)
        { 
            kedi K1 = new kedi();
            K1.isim = "Boncuk";
            K1.kilo = 3;
            K1.renk = "Beyaz";
            K1.ayakSayisi = 4;
            K1.cinsiyet = "Dişi";

            K1.sesCikar();
            K1.HayvanBilgileriGöster();

            Console.ReadLine();
        }
    }
}

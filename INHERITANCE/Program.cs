using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance // Miras alma.
{
    class Program
    {
        static void Main(string[] args)
        {
            kedi K1 = new kedi();
            K1.hayvan_adı = "Patii";
            K1.hayvan_cinsiyet = "Dişi";
            K1.hayvan_türü = "Kedi";
            K1.HayvanYas(2);

            K1.HayvanBilgisiGöster();

            Console.ReadKey();
        }
    }
}

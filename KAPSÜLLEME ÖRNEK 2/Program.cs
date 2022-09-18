using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dikdortgen
{
    class Program
    {
        static void Main(string[] args)
        {
            sekil dortgen = new sekil();
            dortgen.Uzunluk(10);
            dortgen.Genislik(5);
            dortgen.yazdir();

            Console.ReadLine();
        }
    }
}

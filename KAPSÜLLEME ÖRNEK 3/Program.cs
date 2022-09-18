using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareOda
{
    class Program
    {
        static void Main(string[] args)
        {
            Kare sekil = new Kare();

            sekil.Uzunluk(10);
            sekil.Genislik(5);
            sekil.yazdir();

            Console.ReadLine();
        }
    }
}

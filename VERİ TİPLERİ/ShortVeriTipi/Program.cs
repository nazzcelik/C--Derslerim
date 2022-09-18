using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Veri_Tipi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Short değişkeni -32768 ile 32767 arasında değer depolayabilmektedir

            short birinciDegisken = -100;
            short ikinciDegisken = 24679;
            short ucuncuDegisken = 3200;

            short maxDeger = short.MaxValue;
            short minDeger = short.MinValue;

            Console.WriteLine(birinciDegisken);
            Console.WriteLine(ikinciDegisken);
            Console.WriteLine(ucuncuDegisken);

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);

            Console.ReadLine();


           

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusuPratik
{
    class Program
    {
        static void Main(string[] args)
        {
            // Birden 10'a Kadar Olan Sayıları Alt Alta ekrana yazdırna programı kodlayınız...

            /*  for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();  */

            // 1'den 20'ye kadar olan çift sayıları ekrana yazdıran programı kodlayınız...

            for (int i = 0; i <= 20; i += 2) //  i = i + 2
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

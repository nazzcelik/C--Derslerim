using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1'den 10'a kadar olan sayıları alt alta yazdırınız

            /* int i = 1;

             while (i<=10)
             {
             Console.WriteLine(i);
                 i += 1;
             }

             Console.ReadLine();  */

            //  100'den 0'a Kadar olan sayıların çift olanlarını büyükten küçüğe doğru yazdırın..

            int i = 100;
            while (i >= 0) 
            {
                Console.WriteLine(i);
                i -=2 ;
            }
            Console.ReadLine(); 
        }

    } 
    
}

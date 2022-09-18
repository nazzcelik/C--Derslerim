using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraekVeContinueAnahtarKelimeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Braek Anahatr Kelimesi..
            // Continue Anahtar Kelimesi..

            /*  for (int i = 1; i <= 10; i++)
            {
                if (i==7)
                {
                    break;
                }
                Console.WriteLine("i'nin Değeri :"+i);
            }
            Console.ReadLine();    */

            // Braek Anahatr Kelimesi..
            // Continue Anahtar Kelimesi..

            for (int i = 1; i <= 10; i++)
            {
                if (i == 7)
                {
                    continue;  // sadece 7 değeri yazılmaz
                }
                Console.WriteLine("i'nin Değeri :" + i);
            }
            Console.ReadLine();
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            sayilar[0] = 5;
            sayilar[1] = 10;
            sayilar[2] = 15;
            sayilar[3] = 20;
            sayilar[4] = 25;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
        } 
    }
}

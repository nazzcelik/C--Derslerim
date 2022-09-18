using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDiziii
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] ondalikli_sayilar = { 1.12, 3.14, 2.78 };
            for (int i = 0; i < ondalikli_sayilar.Length; i++) 
            {
                Console.WriteLine(ondalikli_sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}

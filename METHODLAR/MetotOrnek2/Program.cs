using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOrnek4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 tane değer alalım ve ekrana hangisinin daha büyük veya küçük olduğunu yazsın.
            Console.Write("- Lütfen ekrana kıyaslamak istediğiniz 1.sayıyı giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("- Lütfen ekrana kıyaslamak istediğiniz 2.sayıyı giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("***************************************");

            degerler(sayi1, sayi2);
            Console.ReadLine();
        }

        static void degerler(int a, int b)
        {
            if (a>b)
            {
                Console.WriteLine("1. sayı, 2. sayıdan büyüktür...");
            }
            else if(b>a)
            {
                Console.WriteLine("2. sayı, 1. sayıdan büyüktür...");
            }
            else 
            {
                Console.WriteLine("1. sayı ve 2. sayı birbirine eşittir...");
            }
            
        }
    }
}

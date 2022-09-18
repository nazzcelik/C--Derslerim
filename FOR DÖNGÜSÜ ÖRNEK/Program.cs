using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusuOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Sayı Giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            for (int i = 1; i <= sayi; i++)
            {
                toplam += i; // toplam = toplam+i;
            }
            double ortalama = toplam / sayi;

            if (ortalama < 50)
            {
                Console.WriteLine("Ortalamanız 50'den Küçüktür.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ortalamanız 50'den Büyüktür.");
                Console.ReadLine();
            }
        }
    }
}

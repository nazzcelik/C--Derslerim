using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musteriler = new List<Musteri>();
            musteriler.Add(new Musteri(123123, "Naz", "ÇELİK", "naz.celik@gmail.com"));
            musteriler.Add(new Musteri(124124, "Asel", "ÇELİK", "asel.celik@gmail.com"));
            musteriler.Add(new Musteri(125125, "Arjin", "ÇELİK", "arjin.celik@gmail.com"));

            foreach (Musteri M1 in musteriler)
            {
                Console.WriteLine(M1);
                Console.WriteLine("------------------------------------------------------------------------------");
            }

            Console.ReadLine();

        }
    }
}

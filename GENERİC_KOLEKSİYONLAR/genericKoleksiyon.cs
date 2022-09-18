using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> rakamlar = new List<double>();
            rakamlar.Add(0.1);
            rakamlar.Add(1.2);
            rakamlar.Add(2.3);
            rakamlar.Add(3.4);
            rakamlar.Add(4.5);
            rakamlar.Add(5.6);
            rakamlar.Add(6.7);
            rakamlar.Add(7.8);
            rakamlar.Add(8.9);
            rakamlar.Add(9.0);

            foreach (int rakam in rakamlar)
            {
                Console.WriteLine(rakam);
            }
            Console.ReadLine();
        }
    }
}

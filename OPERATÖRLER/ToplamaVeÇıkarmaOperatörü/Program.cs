using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamaVeÇıkarmaOperatörü
{
    class Program
    {
        static void Main(string[] args)
        {
            //Toplama Operatörü : +
            //Çıkarma operatörü : -

            int a = 4;
            int b = 16;
            int c = 3;
            int d = 12;

            int sonuc = (a + b + c) - d;

            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}

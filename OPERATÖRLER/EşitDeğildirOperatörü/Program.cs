using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsitDegildirOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eşit Değildir operatörü : !=

            int a = 6;
            int b = 5;
            bool kontrolEt = a != b;
            Console.WriteLine(kontrolEt);
            Console.ReadLine();
        }
    }
}

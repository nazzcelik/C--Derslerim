using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsittirOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eşittir Operatörü : ==

            int a = 7;
            int b = 7;
            int c = 5;

            bool kontrolEt1 = a == b;
            bool kontrolEt2 = b == c;
            Console.WriteLine(kontrolEt1);
            Console.WriteLine(kontrolEt2);
            Console.ReadLine();
        }
    }
}

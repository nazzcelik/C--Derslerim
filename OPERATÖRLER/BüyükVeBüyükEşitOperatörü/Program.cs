using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukVeBuyukEsitOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Büyütür Operatörü : >
            //Büyük Eşittir Operatörü : >=

            int yas = 19;
            bool KontrolEt1 = yas > 20;
            bool KontrolEt2 = yas >= 19;

            Console.WriteLine(KontrolEt1);
            Console.WriteLine(KontrolEt2);
            Console.ReadLine();
        }
    }
}

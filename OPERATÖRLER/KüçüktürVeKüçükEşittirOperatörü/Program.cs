using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucukturVeKucukEşittirOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Küçüktür Operatörü : <
            //Küçük Eşit Operatörü : <=

            int yas = 19;
            bool KontrolEt = yas < 20;
            bool KontrolEt1 = yas <= 19;

            Console.WriteLine(KontrolEt);
            Console.WriteLine(KontrolEt1);
            Console.ReadLine();
        }
    }
}

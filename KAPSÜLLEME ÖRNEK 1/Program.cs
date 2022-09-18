using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            personel P1 = new personel();

            P1.TC_KİMLİK_NO = "48151623421";
            Console.WriteLine("TC Kimlik numaranız: "+P1.TC_KİMLİK_NO+"******");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedAnahtarKelimesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Papatya papatya = new Papatya();
            papatya.boy = 0.38;
            //papatya.renk = "Beyaz";
            //papatya.Tür = "Papatya";
            //papatya.yas = 1;

            papatya.BilgiGoster();

            Console.ReadLine();
        }
    }
}

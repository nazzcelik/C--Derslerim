using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedAnahtarKelimesi
{
    
    public class Papatya
    //public class Papatya : Bitki
    {
        public double boy;

        public void BilgiGoster()
        {
            Console.WriteLine("BİLGİLER");
            Console.WriteLine("-------------------");
            //Console.WriteLine("Bitki Türü: " + Tür);
            //Console.WriteLine("Bitki Yaşı: " + yas);
            //Console.WriteLine("Bitki Rengi: " + renk);
            Console.WriteLine("Bitki Boyu: " + boy);
            Console.WriteLine("-------------------");
        }
    }
}

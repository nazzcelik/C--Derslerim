using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici K1 = new Kullanici(123456, "Naz", "Çelik");
            K1.BilgileriGoster();
            Console.WriteLine("************");
            K1.ZamYap(500);

            Console.ReadLine();

        }
    }
}

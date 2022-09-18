 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classlar
{
    internal class AltSinif : TemelSinif  // temel sınıfı miras alan sınıflar, temel sınıf içerisinde oluşturduğumuz metot imzalarını iplement etmek zorundadır.
    {
        public override void metot2()  // Ben metot2'yi kullanmak istediğimde override edilmiş metot kullanılır, temel sınıf içindeki değil.
        {
            Console.WriteLine("Metot2 çalıştı.");
        }
    }
}

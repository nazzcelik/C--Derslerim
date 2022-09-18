using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classlar
{
    internal abstract class TemelSinif  // abstract anahtar kelimesini silersem bu sınıfa sadece body(içerik) olan metotlar ekleyebilirim.
    {
        public void metot1()
        {
            Console.WriteLine("Metot1 çalıştı.");  // Metot body.
        }
        public abstract void metot2(); // eğer bu motodu abstract anahtar kelimesi ile işaretlemezsem süslü body {} eklemek zorundayım.
         /*  {
                 Console.ReadLine("Metot2 çalıştı.");
             }
         */

          
    }
}

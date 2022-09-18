using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir nesnenin birden fazla nesne gibi davranmasıdır.

            hayvan Hayvan = new hayvan("Hayvan");
             Hayvan.konus();

             hayvan Kedi = new kedi("Pamuk");  // Benim kedi sınıfın hayvan sınıfını miras aldığı için nesnemi oluşturduğumda kedi sınıfından değil de hayvan sınıfından oluşturabilirim.
             Kedi.konus();

             kopek Kopek = new kopek("Karakaş");
             Kopek.konus();

             Console.ReadLine();   

           /* HayvanlariKonustur(new kedi("Pamuk"));
            HayvanlariKonustur(new kopek("Karakaş"));
            HayvanlariKonustur(new hayvan("Hayvan"));

            Console.ReadLine();   */

            
        }

       /*
        public static void HayvanlariKonustur(hayvan hayvan)
        {
            hayvan.konus();
        }    
        
       */
    }
}

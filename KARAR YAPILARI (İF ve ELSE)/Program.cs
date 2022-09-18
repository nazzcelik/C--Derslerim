using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari_ifElse_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Öğrencinin notu 50'den büyükse başarılı,
            küçükse başarısız yazdıran programı kodlayınız. */

            int not = 47;

            if (not>50)
            {
                Console.WriteLine("Dersi Başarıyla Geçtiniz. TEBRİKLR!");
                Console.ReadLine();
                    
            }
            else
            {
                Console.WriteLine("Bu dersten başarısız oldunuz");
                Console.ReadLine();
            }

         

        }
    }
}

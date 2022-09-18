using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakPointVeToolTİpOnemi
{
    class Program
    {
        static void Main(string[] args)
        {
            // BreK Point yazılan kodların arka tarafta nasıl çalıştığını gösterir, yani kodları teker teker çalıştırır
            // Break Point çalıştırmak istediğimiz kodun en solundaki çizgiye, kod satırı hizzasında basıp çalıştırmamızı sağlar.
            // Braek Point özetle bütün kodların üzerinden tek tek geçmek demektir.

            int a = 3;
            int b = 5;
            int c = 10;

            int sonuc = a + b + c;
            Console.WriteLine(sonuc);
            Console.ReadLine();

            //Tooltip; kod yazarken çıkar kısa açıklama kutularıdır. Onları her daim oku.
        }
    }
}

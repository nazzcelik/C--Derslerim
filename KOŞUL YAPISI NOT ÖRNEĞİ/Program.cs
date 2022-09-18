using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulYapisiNotOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Kullanıcıdan 3 tane not alan ve bu notların ortalamasını bulan, ortalaması 
             eğer 80-100 arasındaysa A+ yazdıran
             60-80 arasındaysa A yazdıran
             40-60 arasındaysa B+ yazdıran
             40 altı ise F yazdıran kod örneğinin parçalarını yazınız... */

            Console.WriteLine("Lütfen Birinci Notunuzu Giriniz...");
            string birinciNot = Console.ReadLine();

            Console.WriteLine("Lütfen İkinci Notunuzu Giriniz...");
            string ikinciNot = Console.ReadLine();

            Console.WriteLine("LÜtfen Üçüncü Notunuzu Giriniz...");
            string ucuncuNot = Console.ReadLine();

            int birinci_not = Convert.ToInt32(birinciNot);
            int ikinci_not = Convert.ToInt32(ikinciNot);
            int ucuncu_not = Convert.ToInt32(ucuncuNot);

            int sonuc = (birinci_not + ikinci_not + ucuncu_not) / 3;
            Console.WriteLine("Ortalamanız : "+sonuc);
            Console.ReadLine();

            if (sonuc>80 && sonuc<100)
            {
                Console.WriteLine("Notunuz : A+ ");
                Console.ReadLine();
            }
            else if (sonuc>60 && sonuc<80)
            {
                Console.WriteLine("Notunuz : A");
                Console.ReadLine();
            }
            else if (sonuc>40 && sonuc<60)
            {
                Console.WriteLine("Notunuz : B+");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Notunuz : F");
                Console.ReadLine();
            }
           
            
        }
    }
}

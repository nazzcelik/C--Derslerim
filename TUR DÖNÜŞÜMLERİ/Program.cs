using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // (İNT VERİ TİPİNDEN BYTE VERİ TİPİNE DÖNÜŞÜM)

            // int a = 5;
            // byte b = (byte)a;
            // Console.WriteLine(b.GetType());
            // Console.WriteLine(b);
            // Console.ReadLine();

            // (STRİNG VERİ TİPİNDEN İNT VERİ TİPİNE DÖNÜŞÜM)

            // YÖNTEM-1: (int.parse) ile

            // string sayi1 = "1";
            // string sayi2 = "2";
            // int a = int.Parse(sayi1);
            // int b = int.Parse(sayi2);
            // Console.WriteLine(a+b);

            // YÖNTEM -2: (Convert.ToInt32) ile

            // int a = Convert.ToInt32(sayi1);

            // int b = Convert.ToInt32(sayi2);

            // Console.WriteLine(a+b);
            // Console.ReadLine();

            // (INT VERİ TİPİNDEN STRİNG VERİ TİPİNE DÖNÜŞÜM)

            /* int sayi1 = 5;
            int sayi2 = 12;

            string a = sayi1.ToString();
            string b = sayi2.ToString();

            Console.WriteLine(a+b);
            Console.ReadLine(); */

            // (DOUBLE VERİ TİPİNDEN INT VERİ TİPİNE DÖNÜŞÜM)

            // double sayi = 3.32;

            // int a = Convert.ToInt32(sayi);
            // Console.WriteLine(a);
            // Console.ReadLine();

            /* KULLSNICIDAN ALINAN DEĞERLER STRİNG VERİ TİPİNDE OLUR... */

            Console.WriteLine("Lütfen yaşınızı yazınız:");
            string yas1 = Console.ReadLine();

            Console.WriteLine("Lütfen doğum yılınızı yazınız:");
            string yil1 = Console.ReadLine();

            int yas2int = Convert.ToInt32(yas1);
            int yil2int = Convert.ToInt32(yil1);


            Console.WriteLine("İki Değerin Toplamı:" +( yas2int + yil2int));            
            Console.ReadLine();

            // ToString();
            // Convert.ToInt32();
            // Int.parse();
            // Double.parse();
            // (int)
            


            

           


        


            

            
     

            
        }
    }
}

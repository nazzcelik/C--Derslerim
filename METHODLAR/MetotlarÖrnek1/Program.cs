using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan aldığımız sayının karesini alalım
            // Eğer sayının karesi 25'ten büyükse; Girdiğiniz sayının karesi 25'ten büyüktür yazdırsın
            // sayının karesi 25'ten küçükse küçüktür yazdırsın...

            Console.WriteLine("Lütfen karesini almak istediğiniz sayıyı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int karesi = KareAl(sayi);

            if (karesi<25)
            {
                Console.WriteLine("Girmiş Olduğunuz Değerin Karesi 25'ten Büyüktür...");
            }
            else
            {
                Console.WriteLine("Girmiş Olduğunuz Değerin Karesi 25'ten Büyüktür...");
            }
            Console.ReadLine();

        }

        static int KareAl(int a)
        {
            return a * a;
        }






    }
}

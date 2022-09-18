using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnegi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Eleman sayısını kullanıcının belirlediği bir dizi oluşturarak içine kullanıcının eleman girmesini sağlayan örnek:

            int mevcut = 0;

            Console.Write("Lütfen Sınıf Mevcudunu Giriniz :");
            mevcut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            string[] ogrenci = new string[mevcut];

            for (int i = 0; i < mevcut; i++)
            {
                Console.Write("Lütfen "+(i+1)+". Öğrenci Adını Giriniz :");
                ogrenci[i] = Console.ReadLine();
            }

            Console.WriteLine("====================================");
            Console.WriteLine("nazz@nazzcelik.com");

            Console.ReadLine();

           

        }
    }
}

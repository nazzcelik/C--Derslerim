using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan değerin tek mi çift mi olduğunu bulan metot
           
            Console.Write("Lütfen sorgulamak istediğiniz sayıyı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("=================================================");
            TekmiCiftmi(sayi);
            Console.ReadLine();


        }

        static void TekmiCiftmi(int sayi)
        {
            if (sayi%2==0)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir...");
                
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tektir...");
                
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnegi1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] degerler = { 12, 34, 24, 12, 56, 12, 34, 55, 56, 34, 70, 80, 45, 70, 80, 80, 80 };
            int adet = 0;
            int sayi;

            Console.Write("Lütfen Bir sayı Giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < degerler.Length; i++)
            {
                if (sayi == degerler[i])
                {
                    adet++;
                }
            }
            if (adet == 0)
            {
                Console.WriteLine("Girdiğiniz Değer Dizide Bulunmuyor... ");
            }
            else
            {
                Console.WriteLine("Girdiğiniz Değer Dizide "+(adet)+" adet bulunuyor...");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizininElemanlarınıKullanicidanAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Sayılar Dizisinin "+(i+0)+". index Değerini Giriniz : ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("*********************************************");

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}

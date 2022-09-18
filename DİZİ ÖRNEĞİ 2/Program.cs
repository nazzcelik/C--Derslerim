using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerOrnegi2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];

            int tekSayiAdedi = 0;
            int ciftSayiAdedi = 0;

            int tekSayiToplam = 0;
            int ciftSayiToplam = 0;

            int kullaniciDeger;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Lütfen " + (i + 0) + " . index değerini giriniz :");
                kullaniciDeger = int.Parse(Console.ReadLine());

                sayilar[i] = kullaniciDeger; //Dizimin içini kullanıcıdan aldığım değerlerle dolduruyorum.
            }

            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j]%2==0) // Sayilar dizimdeki değerin 2 ile ölümünden kalan 0 ise (Çift sayı)
                {
                    ciftSayiAdedi++;
                    ciftSayiToplam += sayilar[j];
                }
                else
                {
                    tekSayiAdedi++;
                    tekSayiToplam += sayilar[j];
                }
            }
            Console.WriteLine("");

            if (ciftSayiToplam > tekSayiToplam)
            {
                Console.WriteLine("Çift Sayılarınızın Toplamı Tek Sayılarınızın Toplamından Büyüktür.");
            }
            else
            {
                Console.WriteLine("Tek Sayılarınızın Toplamı Çift Sayılarınızın Toplamından Büyüktür.");
            }

            Console.WriteLine("***************************************");

            Console.WriteLine("Çift Sayılarınızın Toplamı :" + ciftSayiToplam);
            Console.WriteLine("Çift Sayılarınızın Adedi :" + ciftSayiAdedi);

            Console.WriteLine("***************************************");

            Console.WriteLine("Tek Sayılarınızın Toplamı :" + tekSayiToplam);
            Console.WriteLine("Tek Sayılarınızın Adedi :" + tekSayiAdedi);

            Console.ReadLine();




        }
    }
}

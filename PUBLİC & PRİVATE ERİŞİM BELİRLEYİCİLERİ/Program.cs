using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyicileri
{
    class Program
    {
        static void Main(string[] args)
        {
            // public -- private 

            Musteri musteri1 = new Musteri();

            musteri1.personelIsim = "Enes";
            musteri1.personelSoyisim = "Bilmem ne";
            musteri1.maas = 5700;
            musteri1.cinsiyet = "Erkek";
            

            musteri1.personelBilgileriGoster();

            Console.ReadLine();

         

        }
    }
}

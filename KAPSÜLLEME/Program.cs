using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    class Program
    {
        static void Main(string[] args)
        {
            emlak eml = new emlak();

            eml.SEMT = "Bahçelievler";
            eml.RENK = "Sİyah";
            eml.ODA_SAYISI = 4;
            eml.KAT_NO = 7;
            eml.ALAN=95.68;

            Console.WriteLine("Semt: "+eml.SEMT);
            Console.WriteLine("Renk: "+eml.RENK);
            Console.WriteLine("Oda Sayısı: "+eml.ODA_SAYISI);
            Console.WriteLine("Kat Numarası: "+eml.KAT_NO);
            Console.WriteLine("Alan: "+eml.ALAN+" Metrekare");

            Console.ReadLine();
        }
    }
}

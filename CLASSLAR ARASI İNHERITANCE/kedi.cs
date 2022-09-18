using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslarArasiInheritance
{
   public class kedi :kopek
    {
        public void sesCikar()
        {
            Console.WriteLine("Kedi Ses Çıkarıyor...");
        }
        public void HayvanBilgileriGöster()
        {
            Console.WriteLine("İsim: "+isim);
            Console.WriteLine("Hayvan Rengi: "+renk);
            Console.WriteLine("Hayvan Kilo: "+kilo);
            Console.WriteLine("Hayvanın Ayak Sayısı: "+ayakSayisi);
            Console.WriteLine("Hayvanın Cinsiyeti: "+cinsiyet);
        }
    }
}

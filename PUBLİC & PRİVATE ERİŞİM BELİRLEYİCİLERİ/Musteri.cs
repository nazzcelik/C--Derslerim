using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyicileri
{
    public class Musteri
    {
        public string personelIsim;
        public string personelSoyisim;
        public int maas;
        private int yas;
        public string cinsiyet;

        public void personelBilgileriGoster()
        {
            Console.WriteLine("Personel ismi : " + personelIsim);
            Console.WriteLine("Personel Soyisim : " + personelSoyisim);
            Console.WriteLine("Maaş : " + maas);
            Console.WriteLine("Cinsiyet : " + cinsiyet);
        }

        private void isimSoyisimYazdir()
        {
            Console.WriteLine("Personel ismi ve soyismi : "+personelIsim+" "+personelSoyisim);
        }

    }
}

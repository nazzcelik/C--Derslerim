using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareOda
{
    class Kare
    {
        private double uzunluk;
        private double genislik;

        public void Uzunluk(double sayi1)
        {
            uzunluk = sayi1;
        }
        public void Genislik(double sayi2)
        {
            genislik = sayi2;
        }
        public double AlanGetir()
        {
            return uzunluk * genislik;
        }
        public void yazdir()
        {
            Console.WriteLine("Uzunluk: {0}",uzunluk);
            Console.WriteLine("Genislik: {0}",genislik);
            Console.WriteLine("Alan: {0}",AlanGetir());
        }
    }
}

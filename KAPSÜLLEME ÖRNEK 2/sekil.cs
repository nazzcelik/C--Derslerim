using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dikdortgen
{
    class sekil
    {
        private double genislik;
        private double uzunluk;

        public void Genislik (double sayi1)
        {
            genislik = sayi1;
        }
        public void Uzunluk(double sayi2)
        {
            uzunluk = sayi2;
        }
        public double AlanGetir()
        {
            return uzunluk * genislik;
        }
        public void yazdir()
        {
            Console.WriteLine("Genişlik: {0}",genislik);
            Console.WriteLine("nlukUzu: {0}",uzunluk);
            Console.WriteLine("Alan: {0}",AlanGetir());
        }
    }
}

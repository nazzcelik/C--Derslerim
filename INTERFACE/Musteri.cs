using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Musteri : Imusteri,Ipersonel // Bir class sadece bir class tan türetebilirken, bir Class birden çok Interface ten türetilebilir.
    {
        // Interface leri miras alan sınıflar, içerisinde tanımlanan tüm metodlari Implemente etmek zorundadır.
        public void ekle()
        {
            Console.WriteLine("Müşteri eklendi.");
        }

        public void getir()
        {
            Console.WriteLine("Müşteri getirildi.");
        }

        public void guncelle()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }

        public void PersonelEkle()
        {
            Console.WriteLine("Personel eklendi.");
        }

        public void sil()
        {
            Console.WriteLine("Müşteri silindi.");
        }
    }
}

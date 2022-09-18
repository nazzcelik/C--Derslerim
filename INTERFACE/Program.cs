using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interface'lerden bir tane örnek oluşturamazsınız.
            // Interface'i implement'e eden classdan aldığımız örneği interface karşılayabilir.
            // Interface içerisinde metotları tanımlarız. Classlarda da içeriğini doldururuz. 
            // Interface içindeki metotların ERİŞİM BELİRLEYİCİLERİ ve İÇERİĞİ olmaz.
            // Interface leri miras alan sınıflar, içerisinde tanımlanan tüm metodlari Implemente etmek zorundadır.
            // Bir class sadece bir class tan türetebilirken, bir Class birden çok Interface ten türetilebilir.

            Musteri musteri = new Musteri();
            musteri.ekle();
            musteri.getir();
            musteri.guncelle();

            Imusteri imusteri = new Musteri();  // Interface'i implement'e eden classdan aldığımız örneği interface karşılayabilir.
            imusteri.sil();

            Console.ReadLine(); 
        }
    }
}

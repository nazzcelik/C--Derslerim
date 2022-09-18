using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMetot
{
    class Kullanici
    {
        private int KullaniciID;
        private string isim;
        private string soyisim;
        private static int maas;

        public Kullanici(int ID, string _isim, string _soyisim)
        {
            KullaniciID = ID;
            isim = _isim;
            soyisim = _soyisim;

        }
        static Kullanici()
        {
            maas = 2500;
        }
        public void BilgileriGoster()
        {
            Console.WriteLine("Kullanıcı ID: "+KullaniciID);
            Console.WriteLine("İsim: "+isim);
            Console.WriteLine("Soyisim: "+soyisim);
            Console.WriteLine("Maaş: "+maas);
        }
        public void ZamYap(int yeniZam)
        {
            Console.WriteLine("Zam Yapıldı!");
            Console.WriteLine("Yeni Maaşınız: "+(maas+yeniZam));
        }

    }
}

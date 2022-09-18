using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDegiskenKullanimi
{
    public class Calisan
    {
        public int calisanID;
        public string isim;
        public string soyisim;
        public static int maas;

        //public int calisanID { get; set; }
        //public string isim { get; set; }
        //public string  soyisim { get; set; }
        //public static int maas { get; set; }

        public void yazdir()
        {
            Console.WriteLine("BİLGİLER:");
            Console.WriteLine("------------------");
            Console.WriteLine("Çalışan ID: "+calisanID);
            Console.WriteLine("İsim: "+isim);
            Console.WriteLine("Soyisim: "+soyisim);
            Console.WriteLine("Maaş: "+maas);
        }
    }
}

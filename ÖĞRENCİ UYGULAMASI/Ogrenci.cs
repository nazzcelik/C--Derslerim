using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private double vize1;
        private double vize2;
        private double final;
        private string OkulAdi;


        public Ogrenci(int _ogrenciNo, string _isim, string _soyisim, double _vize1, double _vize2, double _final, string _OkulAdi)
        {
            ogrenciNo = _ogrenciNo;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            OkulAdi = _OkulAdi;
        }

        public void OgrenciBilgileriGoster()
        {
            Console.WriteLine("ÖĞRENCİ BİLGİLERİNİZ :");
            Console.WriteLine("================================");
            Console.WriteLine(" ");
            Console.WriteLine("Öğrenci numarası : " + ogrenciNo);
            Console.WriteLine("Öğrenci Adı : " + isim);
            Console.WriteLine("Öğrenci Soyadı : " + soyisim);
            Console.WriteLine("1. Vize Notu : " + vize1);
            Console.WriteLine("2. Vize Notu : " + vize2);
            Console.WriteLine("Final notu : " + final);
            Console.WriteLine("Okul Adı : " + OkulAdi);
        }

        public double OgrenciOrtalamasiBul()
        {
            double ortalama = (vize1 * 0.2) + (vize2 * 0.2) + (final * 0.6);
            return ortalama;
        }

        public void OkulGetir()
        {
            Console.WriteLine("Okul İsmi : " + OkulAdi);
        }






    }
}

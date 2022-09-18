using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set
{
    class ogrenci
    {
        private string ad;
        private string soyad;
        private int yas;
        private string alan;

        public string AD
        {
            get { return ad; }
            set { ad = value; }
        }
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public int YAS
        {
            get { return yas; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Bu işlem 18 yaşından küçüklerin erişimine kapalıdır!");
                    Console.ReadLine();
                }
                else
                {
                    yas = value;
                }
            }
        }
        public string ALAN
        {
            get { return alan; }
            set { alan = value; }
        }
    }
}


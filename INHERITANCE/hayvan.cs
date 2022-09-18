using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class hayvan
    {
        public string hayvan_türü;
        public string hayvan_adı;
        public string hayvan_cinsiyet;
        private int hayvan_yas;

        public void  HayvanYas(int yas)
        {
            hayvan_yas = yas;
        }

        public void HayvanBilgisiGöster()
        {
            Console.WriteLine("Hayvan İsmi: "+hayvan_adı);
            Console.WriteLine("Hayvan Türü: " + hayvan_türü);
            Console.WriteLine("Hayvan Cinsiyeti: " + hayvan_cinsiyet);
            Console.WriteLine("Hayvan Yaşı: " + hayvan_yas);

        }
    }
}

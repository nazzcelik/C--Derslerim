using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    internal class Musteri
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string mail { get; set; }

        public Musteri(int id, string isim, string soyisim, string mail)
        {
            this.id = id;
            this.isim = isim;   
            this.soyisim = soyisim; 
            this.mail = mail;
        }
        public override string ToString()
        {
            return "ID: " + this.id + " / " + "İsim: " + this.isim + " / " + "Soyisim: " + this.soyisim + " / " + "Mail Adresi: " + this.mail;
        }



    }
}

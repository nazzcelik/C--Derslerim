using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class hayvan
    {
        public string isim { get; set; }

        public hayvan(string isim)
        {
            this.isim=isim;
        }
        
        public string getIsim()
        {
            return this.isim;
        }
        public void setIsim(string isim)
        {
            this.isim = isim;
        }

        public virtual void konus()  // virtual anahtar kelimesi demek oluyor ki, benim bu methodum farklı sınıflarda ezilebilsin, giydirilip değiştirilebilsin.
        {
            Console.WriteLine("Hayvan konuşuyor...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class kedi : hayvan
    {
        public kedi(string isim) : base(isim)
        {

        }

        public override void konus()
        {
            Console.WriteLine(getIsim()+" miyavlıyor...");

        }
    }
}

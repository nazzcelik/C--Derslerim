using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Abstract classlar tamamen kalıtım amaçlı geliştirilmiştir. Bu classlardan herhangi bir örnek oluşturulamaz.
            * TemelSinif temel_sinif = new TemelSinif();
            */ 

            // Abstract class - normal class arasındaki farklar;

            // 1- Normal classlar metot imzası tanımı yapamaz iken Abstract classlarda yapılabilir.
            // 2- Normal classlarda new anahtar kelimesi ile nesne oluşturulabilirken Abstract classlarda yapamayız.

            // Abstract class ile Interface arasındaki fark?
            // --> Bir sınıf Abstract classlardan sadece birini miras alabilirken , o class birden fazla interface'i miras alabilir.     
            

            AltSinif alt_sinif=new AltSinif();
            alt_sinif.metot1();
            alt_sinif.metot2();

            Console.ReadLine();
        }
    }
}

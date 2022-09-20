using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    // Sınıf ismine Repository dememin sebebi classımın veri tabanı ile ilgili olacak olması.
    internal class Repository<T> // Bu şekilde classımızı generic hale getirdik.
    {
        // Biz bu classımızın içine iki tane metot tanımladık ve bu metotlar bütün tiplere hizmet ediyor. Generic classların asıl faydası burada devreye giriyor.
        

        public List<T> Getir()
        {
            // Bu metodun görevi veritabanında ilgili tabloya gitmek ve oradan kayıtları getirmek.


            return null;
        }

        public string  ekle(T data)
        {
            // Veritabanında ilgili tabloya git T tipindeki datayı ekle.
            return "DATA BAŞARILI BİR ŞEKİLDE EKLENMİŞTİR !";
        }








    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeOrnek
{
    public class personel
    {
        private string TCkimlikNo;

        public string TC_KİMLİK_NO
        {
            get
            {

                return TCkimlikNo.Substring(0,5);
            }
            set
            {
                bool kontrol = false;
                if (value.Length==11)
                {
                    for(int i=0; i<value.Length;i++)
                    {
                     bool sayiMi=char.IsNumber(value[i]);
                        if (sayiMi)
                        {
                            // Sayı ise yapmam gereken bir şey yok.
                        }
                        else
                        {
                            kontrol = true;
                        }
                    }
                    if(kontrol)
                    {
                        Console.WriteLine("Geçersiz karakter kullandınız! Lütfen tekrar deneyiniz");
                    }
                    else
                    {
                        TCkimlikNo = value;
                    }

                }
                else
                {
                    Console.WriteLine("Eksik veya hatalı girdiniz!");
                }
            }
        }
    }
}

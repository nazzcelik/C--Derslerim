using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetotKullanimi
{
    public class Okul
    {
        public string okul_adi;
        public int sinif_sayisi;
        public int sira_sayisi;
        public string bina_rengi;

        public Okul(string _okulAdi,int _sinifSayisi,int _siraSayisi,string _binaRengi)
        {
            okul_adi = _okulAdi;
            sinif_sayisi = _sinifSayisi;
            sira_sayisi = _siraSayisi;
            bina_rengi = _binaRengi;
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _3.gun
{
    class sepetmanager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string urunaciklama, int urunFiyati, int StokAdeti)
        {
            Console.WriteLine("Tebriler Sepete Eklendi : " + urunAdi);
        }
         
    }
}

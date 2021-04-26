using System;

namespace _3.gun
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "Elma";
            double Fiyati = 15;
            string Aciklama = "Amasya Elması ";

            string[] meyveler = new string[] { };



            Urun urun1 = new Urun();

            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";



            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------");


            }

            Console.WriteLine("----Metodtlar---- -");

            sepetmanager sepetManager = new sepetmanager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "Yeşil", 12, 10);
                

            
        }
    }
}

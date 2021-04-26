using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici";
            string kurs2 = "Temel Kurs";
            string kurs3 = "Java Kursu";


            string[] kurslar = new string[] { "Yazılım Geliştirici", "Temel Kurs", "Java Kursu","phyton", "c++"};

            //döhgüler kendini tekrar etmek için kullanılır
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar [i]);

            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu - footer");
        }// java için system out print line yazılcak bir de string lerin s si büyük

    }
}

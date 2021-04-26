using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "fatih";
            int yas = 28;

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "c#";
            kurs1.kursunEgitmeni = "Fatih";
            kurs1.izlenmeOrani = 30;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "java";
            kurs2.kursunEgitmeni = "kerem";
            kurs2.izlenmeOrani = 20;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "phyton";
            kurs3.kursunEgitmeni = "Berkay";
            kurs3.izlenmeOrani = 60;

            Kurs kurs4 = new Kurs();
            kurs4.kursAdi = "c++";
            kurs4.kursunEgitmeni = "ahmet";
            kurs4.izlenmeOrani = 100;

            Console.WriteLine(kurs2.kursunEgitmeni + ":" + kurs1.kursunEgitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + ":" + kurs.kursunEgitmeni);

            }

            Console.WriteLine("Hello World!");
        }
        class Kurs
        {
            public string kursAdi { get; set; }
            public string kursunEgitmeni { get; set; }
            public int izlenmeOrani { get; set; }
        }
    }
}


 


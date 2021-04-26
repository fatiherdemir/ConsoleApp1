using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            

            sayi2 = 65;
            sayi1 = sayi2;

            Console.WriteLine(sayi1);


            int[] Sayilar1 = new int[] { 10, 20, 30 };
            int[] Sayilar2 = new int[] { 100, 200, 300};

            Sayilar1 = Sayilar2;
            Sayilar1[0] = 999;



            Console.WriteLine(Sayilar1[0]);

            Console.WriteLine(Sayilar2[0]);

            Console.WriteLine(Sayilar1[2]);




        }
    }
}

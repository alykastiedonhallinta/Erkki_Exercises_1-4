/*
 * Harjoitus1
 * Erkki Kerola
 * 23.9.2019
 */



using System;

namespace Harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tehtävä 1
            int a = 1;
            int b = 2;
            Console.WriteLine(a+b);

            //Tehtävä 2
            Console.WriteLine();


            //Tehtävä 2

            //Tehtävä 3

            //Tehtävä 4

            //Tehtävä 4

            //Tehtävä 5

            //Tehtävä 6

            //apuohjelman kutsu

            int kutsu = Summa(10, 25);
            Console.WriteLine(kutsu);

            Console.WriteLine(Summa(15, 22));
            Console.ReadKey();
                       
        }

        static int Summa(int luku1, int luku2)
           
        {
            int vastaus = luku1 + luku2;
            return vastaus;
        }

        //return luku1 + luku2;
        static void Tulosta(String tuloste)
        {
            Console.WriteLine(tuloste);
        }
    }

}

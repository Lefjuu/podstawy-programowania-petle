using System;

namespace petlaDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = 1;

            do
            {
                int wynik = liczba * liczba;
                Console.WriteLine($"{liczba} do kwadratu = {wynik}");
                liczba++;
            } while (liczba <= 20);

            Console.ReadKey();
        }
    }
}

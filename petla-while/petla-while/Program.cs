using System;

namespace AplikacjaKonsolowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba;
            int sumaKwadratow = 0;
            int minimum = int.MaxValue;

            Console.WriteLine("Podaj liczby od 0 do 10 (aby zakończyć, wpisz 5):");

            while (true)
            {
                Console.Write("Podaj liczbę: ");
                liczba = Convert.ToInt32(Console.ReadLine());

                if (liczba == 5)
                {
                    sumaKwadratow += liczba * liczba;

                    break;
                }

                if (liczba < 0 || liczba > 10)
                {
                    Console.WriteLine("Liczba spoza zakresu 0-10. Spróbuj ponownie.");
                    continue;
                }

                sumaKwadratow += liczba * liczba;

                if (liczba < minimum)
                {
                    minimum = liczba;

                }
            }

            Console.WriteLine($"Suma kwadratów wszystkich podanych liczb: {sumaKwadratow}");
            if (minimum == int.MaxValue)
            {
                Console.WriteLine("Nie podano żadnych liczb w zakresie od 0 do 10.");
            }
            else
            {
                Console.WriteLine($"Najmniejsza liczba to: {minimum}");
            }

            Console.ReadKey();
        }
    }
}

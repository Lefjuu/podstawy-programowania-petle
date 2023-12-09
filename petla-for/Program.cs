using System;

class Program
{
    static void Main()
    {
        for (int x = 0; x <= 10; x++)
        {
            double y = Math.Sqrt(Math.Pow(3, 2)) * x;
            Console.WriteLine($"Dla x = {x}, y = {y}");
        }

        Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}

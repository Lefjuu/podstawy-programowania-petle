using System;

class Program
{
    static void Main()
    {
        double result;
        for (int x = 0; x <= 10; x++)
        {
            result = Math.Sqrt(3) * x; // Obliczenie wartości funkcji y = root(3)*x
            Console.WriteLine($"Dla x = {x}, y = {result}");
        }
    }
}

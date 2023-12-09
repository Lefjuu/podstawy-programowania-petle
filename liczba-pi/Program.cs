using System;

class LiczbaPi
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę punktów do wygenerowania:");
        int totalPoints = Convert.ToInt32(Console.ReadLine());

        int start = Environment.TickCount;

        int pointsInsideCircle = EstimatePi(totalPoints);

        int stop = Environment.TickCount;
        double elapsedTime = (stop - start);

        double estimatedPi = 4.0 * (double)pointsInsideCircle / totalPoints;

        Console.WriteLine($"Przybliżona wartość Pi: {estimatedPi}");
        Console.WriteLine($"Czas obliczeń: {elapsedTime} ms");
        Console.ReadLine();
    }

    static int EstimatePi(int totalPoints)
    {
        Random random = new Random();
        int pointsInsideCircle = 0;

        for (int i = 0; i < totalPoints; i++)
        {
            double x = random.NextDouble();
            double y = random.NextDouble();

            if (IsInsideCircle(x, y))
            {
                pointsInsideCircle++;
            }
        }

        return pointsInsideCircle;
    }

    static bool IsInsideCircle(double x, double y)
    {
        return x * x + y * y <= 1.0;
    }
}

using System;

class petlaForEach
{
    static void Main()
    {
        string[] pets = { "cat", "dog", "parrot", "guinea pig" };

        foreach (string pet in pets)
        {
            if (pet == "dog")
            {
                Console.WriteLine("Skipping 'dog'");
                continue;
            }
            Console.WriteLine(pet);
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

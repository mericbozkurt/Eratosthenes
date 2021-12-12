using System;

public class PrimesSieve
{
    private static int Maximum, Count;
    private static bool[] Primes;

    private static void Main()
    {
        Console.Write("Please write down a number: ");

        Maximum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Primes = new bool[Maximum + 1];

        for (int C = 0; C < Primes.Length; C++)
        {
            Primes[C] = true;
        }

        for (int C = 2; C < Math.Sqrt(Maximum) + 1; C++)
        {
            if (Primes[C - 1])
            {
                for (int N = (int)Math.Pow(C, 2); N <= Maximum; N += C)
                {
                    Primes[N - 1] = false;
                }
            }
        }

        for (int C = 2; C < Primes.Length; C++)
        {
            if (Primes[C - 1])
            {
                Count++;
                Console.Write($"{C} ");
            }
        }

        Console.WriteLine();
        Console.WriteLine($"\nThere are {Count} primes up to {Maximum}");
        Console.Write("\nPress a key to exit.");
        Console.ReadKey();
    }
}
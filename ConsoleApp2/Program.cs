using System;
using System.Linq;

public class PrimesSieve
{
    private static int Maximum, Count;
    private static bool[] Primes;

    private static void Main()
    {
        Console.Write("Please write down a number: ");

        Maximum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Primes = Enumerable.Repeat(true, Maximum).ToArray();

        for (int C = 2; C < Math.Sqrt(Maximum) + 1; C++)
        {
            for (int N = (int)Math.Pow(C, 2); N <= Maximum; N += C)
            {
                Primes[N - 1] = false;
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

        Console.WriteLine("\n");
        Console.WriteLine($"There are {Count} primes up to {Maximum}"); //Primes.Count(B => B == true)
        Console.Write("Press a key to exit.");
        Console.ReadKey();
    }
}

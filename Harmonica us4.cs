// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class HarmonicNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the value of N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N != 0)
        {
            double harmonic = CalculateHarmonic(N);
            Console.WriteLine("The " + N + "th harmonic number is: " + harmonic);
        }
        else
        {
            Console.WriteLine("N should be a non-zero value.");
        }
    }

    static double CalculateHarmonic(int N)
    {
        double harmonic = 0.0;

        for (int i = 1; i <= N; i++)
        {
            harmonic += 1.0 / i;
        }

        return harmonic;
    }
}

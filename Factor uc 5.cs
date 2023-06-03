using System;

class PrimeFactorization
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Prime factors of " + N + " are: ");
        ComputePrimeFactors(N);
    }

    static void ComputePrimeFactors(int N)
    {
        for (int i = 2; i * i <= N; i++)
        {
            while (N % i == 0)
            {
                Console.Write(i + " ");
                N /= i;
            }
        }

        if (N > 1)
        {
            Console.Write(N);
        }
    }
}

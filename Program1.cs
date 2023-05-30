using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of times to flip the coin:");
        string input = Console.ReadLine();
        int numFlips;
        if (!int.TryParse(input, out numFlips) || numFlips <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        Random random = new Random();
        int headsCount = 0;
        int tailsCount = 0;

        for (int i = 0; i < numFlips; i++)
        {
            double flip = random.NextDouble();

            if (flip < 0.5)
            {
                tailsCount++;
            }
            else
            {
                headsCount++;
            }
        }

        double headsPercentage = (double)headsCount / numFlips * 100;
        double tailsPercentage = (double)tailsCount / numFlips * 100;

        Console.WriteLine($"Heads: {headsPercentage}%");
        Console.WriteLine($"Tails: {tailsPercentage}%");
    }
}

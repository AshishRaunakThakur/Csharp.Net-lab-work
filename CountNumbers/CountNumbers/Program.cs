using System;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int positiveCount = 0, negativeCount = 0;

            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] > 0)
                    positiveCount++;
                else if (numbers[i] < 0)
                    negativeCount++;
            }

            Console.WriteLine("Positive numbers count: " + positiveCount);
            Console.WriteLine("Negative numbers count: " + negativeCount);
        }
    }
}
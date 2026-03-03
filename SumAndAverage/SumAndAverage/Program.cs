using System;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            int sum = 0;
            double average;

            Console.WriteLine("Enter marks of 5 students:");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
                sum += marks[i];
            }

            average = sum / 5.0;

            Console.WriteLine("Total Marks: " + sum);
            Console.WriteLine("Average Marks: " + average);
        }
    }
}
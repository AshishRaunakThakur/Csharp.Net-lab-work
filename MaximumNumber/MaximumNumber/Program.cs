using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = arr[0];

            for (int i = 1; i < 5; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine("Maximum number is: " + max);
        }
    }
}
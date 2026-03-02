using System;

namespace MinNumber
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = arr[0];

            for (int i = 1; i < 5; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("Minimum number is: " + min);
        }
    }
}
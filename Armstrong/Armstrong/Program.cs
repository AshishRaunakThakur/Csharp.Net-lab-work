using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main()
        {
            int num, temp, sum = 0;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            temp = num;

            while (num > 0)
            {
                int rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }

            if (temp == sum)
                Console.WriteLine("Number is Armstrong");
            else
                Console.WriteLine("Number is Not Armstrong");
        }
    }
}
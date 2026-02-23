using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main()
        {
            int num, temp, rev = 0;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            temp = num;

            while (num > 0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }

            if (temp == rev)
                Console.WriteLine("Number is Palindrome");
            else
                Console.WriteLine("Number is Not Palindrome");
        }
    }
}
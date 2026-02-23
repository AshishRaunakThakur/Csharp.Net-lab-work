using System;

namespace PalindromeString
{
    class Program
    {
        static void Main()
        {
            string str, rev = "";

            Console.Write("Enter a string: ");
            str = Console.ReadLine();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }

            if (str == rev)
                Console.WriteLine("String is Palindrome");
            else
                Console.WriteLine("String is Not Palindrome");
        }
    }
}
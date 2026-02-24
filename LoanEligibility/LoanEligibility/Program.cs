using System;

namespace LoanEligibility
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, creditScore;
            double income;

            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter Monthly Income: ");
            income = double.Parse(Console.ReadLine());

            Console.Write("Enter Credit Score: ");
            creditScore = int.Parse(Console.ReadLine());

            if (age >= 21)
            {
                if (income >= 25000)
                {
                    if (creditScore >= 650)
                    {
                        Console.WriteLine("Loan Approved");
                    }
                    else
                    {
                        Console.WriteLine("Loan Rejected: Low Credit Score");
                    }
                }
                else
                {
                    Console.WriteLine("Loan Rejected: Insufficient Income");
                }
            }
            else
            {
                Console.WriteLine("Loan Rejected: Age Below Requirement");
            }
        }
    }
}
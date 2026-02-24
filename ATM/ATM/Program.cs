using System;

namespace ATM
{
    class ATM
    {
        static void Main()
        {
            int pin = 1234, enteredPin;
            double balance = 10000, withdrawAmount;

            Console.Write("Enter PIN: ");
            enteredPin = int.Parse(Console.ReadLine());

            if (enteredPin == pin)
            {
                Console.Write("Enter Withdrawal Amount: ");
                withdrawAmount = double.Parse(Console.ReadLine());

                if (withdrawAmount <= balance)
                {
                    balance = balance - withdrawAmount;
                    Console.WriteLine("Withdrawal Successful");
                    Console.WriteLine("Remaining Balance: " + balance);
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }
        }
    }
}
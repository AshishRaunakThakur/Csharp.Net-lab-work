using System;

namespace BillDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            double billAmount, discount = 0;
            string category;

            Console.Write("Enter Bill Amount: ");
            billAmount = double.Parse(Console.ReadLine());

            Console.Write("Enter Customer Category (Senior/Regular/Industrial): ");
            category = Console.ReadLine().ToLower();

            if (category == "senior")
            {
                discount = billAmount * 0.20;
            }
            else if (category == "regular")
            {
                discount = billAmount * 0.10;
            }
            else if (category == "industrial")
            {
                discount = billAmount * 0.05;
            }
            else
            {
                Console.WriteLine("Invalid Category");
            }

            double finalAmount = billAmount - discount;
            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Final Bill Amount: " + finalAmount);
        }
    }
}
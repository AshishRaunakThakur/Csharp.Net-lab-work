using System;

namespace ElectricityBill
{
    class Program
    {
        static void Main()
        {
            int units;
            double bill = 0, totalBill;
            double meterCharge = 50;
            double gst = 0;

            Console.Write("Enter total units consumed: ");
            units = int.Parse(Console.ReadLine());

            if (units <= 100)
            {
                bill = units * 1.5;
            }
            else if (units <= 200)
            {
                bill = (100 * 1.5) + ((units - 100) * 2.5);
            }
            else
            {
                bill = (100 * 1.5) + (100 * 2.5) + ((units - 200) * 4);
            }

            totalBill = bill + meterCharge;

            if (totalBill > 500)
            {
                gst = totalBill * 0.18;
                totalBill = totalBill + gst;
            }

            Console.WriteLine("\nElectricity Bill Details:");
            Console.WriteLine("Units Consumed: " + units);
            Console.WriteLine("Energy Charge: Rs " + bill);
            Console.WriteLine("Meter Charge: Rs " + meterCharge);
            Console.WriteLine("GST: Rs " + gst);
            Console.WriteLine("Total Bill Amount: Rs " + totalBill);
        }
    }
}
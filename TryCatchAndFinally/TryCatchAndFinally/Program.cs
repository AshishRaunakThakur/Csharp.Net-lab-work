using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int result = 100 / num;   // may cause divide by zero

            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        finally
        {
            Console.WriteLine("This block always executes.");
        }
    }
}
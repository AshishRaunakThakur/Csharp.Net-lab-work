using System;
interface Exam
{
    bool Pass(int mark);
}
interface Classify
{
    string Division(int average);
}
class Result : Exam, Classify
{
    public bool Pass(int mark)
    {
        return mark >= 50;
    }
    public string Division(int average)
    {
        if (average >= 60)
            return "First";
        else if (average >= 50)
            return "Second";
        else
            return "No division";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Result result = new Result();

        Console.Write("Enter marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter average: ");
        int avg = Convert.ToInt32(Console.ReadLine());

        if (result.Pass(marks))
            Console.WriteLine("Result: Pass");
        else
            Console.WriteLine("Result: Fail");

        Console.WriteLine("Division: " + result.Division(avg));
    }
}
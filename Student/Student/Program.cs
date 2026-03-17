using System;

class Student
{
    int rollNo;
    string name;
    int marks;

    public Student()
    {
        rollNo = 0;
        name = "Ashish";
        marks = 0;
    }
    public Student(int r, string n, int m)
    {
        rollNo = r;
        name = n;
        marks = m;
    }

    public string CalculateGrade()
    {
        if (marks >= 90)
            return "A";
        else if (marks >= 75)
            return "B";
        else if (marks >= 50)
            return "C";
        else
            return "F";
    }
    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + CalculateGrade());
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        Console.WriteLine("Student using Default Constructor:");
        s1.Display();

        Console.WriteLine();

        Student s2 = new Student(101, "Ashish", 98);
        Console.WriteLine("Student using Parameterized Constructor:");
        s2.Display();
    }
}
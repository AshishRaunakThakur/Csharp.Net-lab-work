using System;

class Employee
{
    int employeeId;
    string name;
    int salary;

    public Employee()
    {
        employeeId = 0;
        name = "Ashish";
        salary = 0;
    }

    public Employee(int i, string n, int s)
    {
        employeeId = i;
        name = n;
        salary = s;
    }
    public int getEmployeeId()
    {
        return salary * 12;
    }
    public void Display()
    {
        Console.WriteLine("Employee Id : " + employeeId);
        Console.WriteLine("Employee Name : " + name);
        Console.WriteLine("Employee Salary : " + salary);
        Console.WriteLine("Annual Salary : " + getEmployeeId());
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine("Employee using default Constructor:");
            e1.Display();

            Console.WriteLine();

            Employee e2 = new Employee(101, "Ashish", 90000);
            Console.WriteLine("Employee using Parameterized Constructor:");
            e2.Display();
        }
    }


}
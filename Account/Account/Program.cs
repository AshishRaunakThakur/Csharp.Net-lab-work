using System;

class Account
{
    public int accountNumber;
    public double balance;

    public Account(int accNo, double bal)
    {
        accountNumber = accNo;
        balance = bal;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public virtual void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }
}

class SavingsAccount : Account
{
    public double interestRate;

    public SavingsAccount(int accNo, double bal, double rate)
        : base(accNo, bal)
    {
        interestRate = rate;
    }

    // Method Overriding
    public override void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Savings Withdraw: " + amount);
        }
        else
        {
            Console.WriteLine("Cannot withdraw beyond balance in Savings Account");
        }
    }
}

class CurrentAccount : Account
{
    public double overdraftLimit;

    public CurrentAccount(int accNo, double bal, double limit)
        : base(accNo, bal)
    {
        overdraftLimit = limit;
    }

    // Method Overriding
    public override void Withdraw(double amount)
    {
        if (amount <= (balance + overdraftLimit))
        {
            balance -= amount;
            Console.WriteLine("Current Withdraw: " + amount);
        }
        else
        {
            Console.WriteLine("Overdraft limit exceeded");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SavingsAccount s = new SavingsAccount(101, 5000, 5);
        CurrentAccount c = new CurrentAccount(102, 3000, 2000);

        s.Deposit(1000);
        s.Withdraw(7000);

        c.Deposit(500);
        c.Withdraw(4500);
    }
}
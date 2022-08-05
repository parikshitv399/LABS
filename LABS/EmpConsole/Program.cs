using System;
using EmpBL;

class Program
{
    public static void Main()
    {
        Hire();
        A a = new C();
        a.Call();

        B b = new C();
        b.Call();

        A x = new B();
        x.Call();
    }

    private static void Hire()
    {
        Employee emp = new Employee();
        Console.WriteLine($"Enter Emp ID");
        emp.EmpID = Console.ReadLine();
        Console.WriteLine($"Enter Emp Name");
        emp.EmpName = Console.ReadLine();
        Console.WriteLine($"Enter Emp Designation");
        emp.EmpDesignation = Console.ReadLine();
        Console.WriteLine($"Enter Emp Salary");
        emp.EmpSalary = Console.ReadLine();
        emp.Work();
        Console.WriteLine($"{emp.EmpName} with {emp.EmpID} ID Number has designation of an {emp.EmpDesignation}");
        emp.ApplyLeave();
    }
}
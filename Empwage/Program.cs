using System;
using EmployeeWageComputation;
class Program
{
    public static void Main(String[] args)
    {
        EmployeeWage computation = new EmployeeWage();
        Console.WriteLine("Enter the Compnay Name");
        string Comp_Name = Console.ReadLine();
        Console.WriteLine("Enter the Employee Salary Pr Hours");
        int empWage_PrHours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Maximum Working Hours Of That Company");
        int maxWorking_Hour = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Working Days in One Month");
        int workingDays_In_OneMonth = Convert.ToInt32(Console.ReadLine());
        computation.monthlyEmpWage(Comp_Name, empWage_PrHours, maxWorking_Hour, workingDays_In_OneMonth);
    }
}

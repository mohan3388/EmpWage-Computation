using System;
using EmpWage;

class program
{

    public static void Main(string[] args)
    {
        //Console.WriteLine("Enter the Compnay Name");
        //string CompanyName = Console.ReadLine();
        //Console.WriteLine("Enter the Employee Salary Per Hours");
        //int EmpSalaryPerHrs = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the Maximum Working Hrs Of Company");
        //int CompanyMaxWorkingHrs = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the Working Days in 1 Month");
        //int CompanyMaxWorkingDay = Convert.ToInt32(Console.ReadLine());
        //EmployeeWageComputation company = new EmployeeWageComputation(CompanyName, EmpSalaryPerHrs, CompanyMaxWorkingHrs, CompanyMaxWorkingDay);

        new EmployeeWageComputation("Dmart", 10, 20, 30);
        new EmployeeWageComputation("vishal", 10, 40, 50);
        
    }
}
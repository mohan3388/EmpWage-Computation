using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    class EmployeeWageComputation
    {
        //Constant
        const int Is_Full_Time = 1;
        const int Is_Part_Time = 2;

        //variable
        string CompanyName;
        int EmpSalaryPerHrs;
        int CompanyMaxWorkingHrs;
        int CompanyMaxWorkingDay;
        public EmployeeWageComputation(string CompanyName, int EmpSalaryPerHrs, int CompanyMaxWorkingHrs, int CompanyMaxWorkingDay)
        {
            int totalSalary = 0;
            int empHrs = 0;
            int totalEmpHrs = 0;

            this.EmpSalaryPerHrs = EmpSalaryPerHrs;
            this.CompanyName = CompanyName;
            this.CompanyMaxWorkingHrs = CompanyMaxWorkingHrs;
            this.CompanyMaxWorkingDay = CompanyMaxWorkingDay;


            for (int i = 1; i <= CompanyMaxWorkingDay; i++)
            {
                Random random = new Random();
                int check = random.Next(0, 3);

                switch (check)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        break;
                    case Is_Part_Time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                int salary = empHrs * EmpSalaryPerHrs;
                Console.WriteLine("Day" + i + " = " + salary);
                if (empHrs <= CompanyMaxWorkingDay)
                {
                    totalEmpHrs = totalEmpHrs + empHrs;
                }
                totalSalary = totalEmpHrs * EmpSalaryPerHrs; ;
            }

            Console.WriteLine(" Company Name" + " = " + CompanyName);
            Console.WriteLine(" Total Emp Hrs" + " = " + totalEmpHrs);
            Console.WriteLine("Company per Hrs Salary" + " = " + EmpSalaryPerHrs);
            Console.WriteLine("Total Salary of Company" + " = " + totalSalary);


        }
    }
}
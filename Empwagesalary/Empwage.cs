using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int PartTime = 1;
        const int FullTime = 2;
        const int EmpWagePrHr = 20;
        const int FullDay_Working_Hr = 8;
        const int PartTime_Time_Working_Hr = 4;
        const int EmpWorking_Pr_Month = 20;
        const int Max_Working_Hr = 100;


        int empHrs = 0;
        int EmpTotalSalary = 0;
        int EmpTotalEmpHrs = 0;
        int day = 0;

        public void monthlyEmpWage()
        {
            while (day <= EmpWorking_Pr_Month && empHrs <= Max_Working_Hr)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case FullTime:

                        empHrs += FullDay_Working_Hr;
                        break;
                    case PartTime:

                        empHrs += PartTime_Time_Working_Hr;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                day++;
            }

            EmpTotalSalary = empHrs * EmpWagePrHr;
            Console.WriteLine("One month Employee Salary is :" + EmpTotalSalary);
        }


    }
}

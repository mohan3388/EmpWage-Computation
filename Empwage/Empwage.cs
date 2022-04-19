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
        const int EmpFullDay_WorkHr = 8;
        const int EmpPartTime_WorkHr = 4;

        
        int empHrs = 0, totalEmpSalary = 0, day = 0;

        public void monthlyEmpWage(string Company_Name, int EMP_WAGE_PR_HR, int MAX_WORKING_HR, int EMP_WORKING_Days_PR_MONTH)
        {
            while (day <= EMP_WORKING_Days_PR_MONTH && empHrs <= MAX_WORKING_HR)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case FullTime:

                        empHrs += EmpFullDay_WorkHr;
                        break;
                    case PartTime:

                        empHrs += EmpPartTime_WorkHr;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                day++;

            }

            totalEmpSalary = empHrs * EMP_WAGE_PR_HR;
            Console.WriteLine("One month Employee Salary is :" + totalEmpSalary);
        }


    }
}
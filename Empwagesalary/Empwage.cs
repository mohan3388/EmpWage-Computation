using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateEmpWage
{
    public class EmpWage
    {
        public int Present = 1;
        public const int FullTime = 0, PartTime = 1, Absent = 2, WageHour = 20;

        public static void CheckEmployee()
        {

            int EmpHour = 0;

       

        int EmpMonthly = 0;
             for(int i=0; i<=WageHour; i++)
            {

                Random TimeCheck = new Random();
                int CheckTime = TimeCheck.Next(0, 3);
                switch (CheckTime)
                {
                    case 0:
                        Console.WriteLine("Day: " + i + " Employee Is Present");
                        EmpHour = 8;

                        break;

                    case 1:
                        Console.WriteLine("Day: " + i + " Employee Is Parttime Present");
                        EmpHour = 4;

                        break;

                    case 2:
                        Console.WriteLine("Day: " + i + " Employee Is Absent");
                        EmpHour = 0;

                        break;
                }
                int EmpWageDaily = EmpHour * WageHour;
                Console.WriteLine("Total Empwage: "+EmpWageDaily);
                EmpMonthly += EmpWageDaily;
               
            }
            int Wage = EmpHour * WageHour;
            Console.WriteLine("Monthly Wage is " + EmpMonthly);




        }
    }
}

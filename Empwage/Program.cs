namespace Empwage
{
    class Program
    {
        public static void Main(string[] args)
        {
            TotalEmployeeWage EmployeeWage = new TotalEmployeeWage();

            EmployeeWage.AddCompany("Reliance", 30, 10, 4, 100, 20);
            EmployeeWage.MonthlyWages("Reliance");
            EmployeeWage.AddCompany("Amazon", 25, 6, 4, 100, 20);
            EmployeeWage.MonthlyWages("Amazon");
            EmployeeWage.AddCompany("TCS", 20, 8, 4, 100, 20);
            EmployeeWage.MonthlyWages("TCS");
            EmployeeWage.AddCompany("Accenture", 20, 8, 4, 100, 20);
            EmployeeWage.MonthlyWages("Accenture");
            EmployeeWage.ViewWage();
        }
    }
}
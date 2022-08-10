namespace Empwage
{
    class Program
    {
        public static void Main(string[] args)
        {
            TotalEmployeeWage wage = new TotalEmployeeWage(4);
           // EmployeeWage wage = new EmployeeWage(4);
            wage.AddCompany("Reliance", 30, 10, 4, 100, 20);
            wage.MonthlyWages("Reliance");
            wage.AddCompany("Amazon", 25, 6, 4, 100, 20);
            wage.MonthlyWages("Amazon");
            wage.AddCompany("TCS", 20, 8, 4, 100, 20);
            wage.MonthlyWages("TCS");
            wage.AddCompany("Accenture", 20, 8, 4, 100, 20);
            wage.MonthlyWages("Accenture");
        }
    }
}
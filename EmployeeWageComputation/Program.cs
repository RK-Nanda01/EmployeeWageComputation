namespace EmployeeWageComputation;
class Program
{
    static void Main(string[] args)
    {
        //START
        Console.WriteLine("Welcome to Employee Wage Computation!");

        //UC1
        Employee emp = new Employee();
        emp.IsPresent();
        Console.ReadLine();


        //UC2
        emp.DailyWage();
        Console.ReadLine();

        //UC3
        Console.WriteLine("UC3:-");
        emp.PartTime();
        Console.ReadLine();

        //UC4
        emp.PartTimeSwtich();
        Console.ReadLine();

        //UC5
        emp.MonthlyWage();
        Console.ReadLine();

        //UC6
        emp.TotalWage();
        Console.ReadLine();

    }

}


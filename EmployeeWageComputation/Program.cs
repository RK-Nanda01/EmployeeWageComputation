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

        //UC3
        Console.WriteLine("UC3:-");
        emp.PartTime();

    }

}


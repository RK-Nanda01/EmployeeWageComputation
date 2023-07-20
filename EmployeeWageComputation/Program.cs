namespace EmployeeWageComputation;
class Program
{
    static void Main(string[] args)
    {
        //START
        Console.WriteLine("Welcome to Employee Wage Computation!");
        Employee emp = new Employee();
        bool flag = true;
        int option;
        while (flag)
        {
            Console.WriteLine("Menu->");
            Console.WriteLine("1.Check if Employee Present or Absent");
            Console.WriteLine("2.Calculate Daily Wage");
            Console.WriteLine("3.Check if Employee is PartTime or Full Time");
            Console.WriteLine("4.Check if Employee is PartTime or Full Time using Switch Case");
            Console.WriteLine("5.Calculate Monthly Wage of Employee");
            Console.WriteLine("0.Exit");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 0:
                    {
                        flag = false;
                        break;
                    }

                case 1:
                    {
                        emp.IsPresent();
                        break;
                    }

                case 2:
                    {
                        emp.DailyWage();
                        break;
                    }
                case 3:
                    {
                        emp.PartTime();
                        break;

                    }
                case 4:
                    {
                        emp.PartTimeSwtich();
                        break;

                    }
                case 5:
                    {
                        emp.MonthlyWage();
                        break;

                    }
                case 6:
                    {
                        emp.TotalWage();
                        break;

                    }



            }


        }
    }

}


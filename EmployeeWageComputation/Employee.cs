using System;
namespace EmployeeWageComputation
{
	public class Employee
	{
		public int IsPresent()
		{
			const int PRESENT = 1;
			Random rnd = new Random();
			int rnd_num = rnd.Next(0, 2);


			if(rnd_num == PRESENT)
			{
				Console.WriteLine("The Employee is Present");
				return 1;
			}

			else
			{

                Console.WriteLine("The Employee is Absent");
				return 0;
            }

		}

		//UC2//
		public int DailyWage()
		{

			const int RATE_PER_HOUR = 20;
			int empHour = 0;
			int wage;


       

            if (this.IsPresent() == 1)
			{
				empHour = 8;
			}

			wage = RATE_PER_HOUR * empHour;

			Console.WriteLine($"The Daily Wage of the Employee is {wage}");
			return wage;
		}
		




	}
}


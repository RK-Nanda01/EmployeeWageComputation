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

		




	}
}


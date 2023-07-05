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



        //UC3

        public int PartTime()
        {

			const int PART_TIME = 1;
			const int FULL_TIME = 2;
			const int ABSENT = 0;
            const int RATE_PER_HOUR = 20;
            int empHours = 0;
			int wage;

            Random rnd = new Random();
            int rnd_num = rnd.Next(0, 3);
			

			if(rnd_num == FULL_TIME)
			{
				empHours = 8;

			}

			else if(rnd_num == PART_TIME)
			{
				empHours = 4;
			}

			else
			{
				empHours = 0;
			}

			wage = empHours * RATE_PER_HOUR;

			Console.WriteLine($"Emp Wage is {wage}");
			return wage;


        }

		public int PartTimeSwtich()
		{
            const int PART_TIME = 1;
            const int FULL_TIME = 2;
            const int ABSENT = 0;
            const int RATE_PER_HOUR = 20;
            int empHours = 0;
            int wage;

            Random rnd = new Random();
            int rnd_num = rnd.Next(0, 3);

			switch(rnd_num)
			{

				case PART_TIME:
				{
						empHours = 4;
						break;
				}

				case FULL_TIME:
				{
						empHours = 8;
						break;
				}

				 default:
				{
						empHours = 0;
						break;
				}


			}

			wage = empHours * RATE_PER_HOUR;
			Console.WriteLine($"UC-4 Wage of Employee is {wage}");
			return wage;

        }



    }



}


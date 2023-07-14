using System;
namespace EmployeeWageComputation
{
    
	public class Employee
	{
        const int PRESENT = 1;
        const int RATE_PER_HOUR = 20;
        const int PART_TIME = 1;
        const int FULL_TIME = 2;
        const int TOTAL_WORKING_DAY = 20;
        //int totalHours = 0,wage = 0, empHour = 0;
        
        public int IsPresent()
		{
			//const int PRESENT = 1;
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

			//const int RATE_PER_HOUR = 20;
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

			//const int PART_TIME = 1;
			//const int FULL_TIME = 2;
			//const int ABSENT = 0;
   //         const int RATE_PER_HOUR = 20;
            int empHour = 0;
            int wage;

            Random rnd = new Random();
            int rnd_num = rnd.Next(0, 3);
			

			if(rnd_num == FULL_TIME)
			{
				empHour = 8;

			}

			else if(rnd_num == PART_TIME)
			{
				empHour = 4;
			}

			else
			{
				empHour = 0;
			}

			wage = empHour * RATE_PER_HOUR;

			Console.WriteLine($"Emp Wage is {wage}");
			return wage;


        }

		public int PartTimeSwtich()
		{
            //const int PART_TIME = 1;
            //const int FULL_TIME = 2;
            //const int ABSENT = 0;
            //const int RATE_PER_HOUR = 20;
            int empHour = 0;
            int wage;

            Random rnd = new Random();
            int rnd_num = rnd.Next(0, 3);

			switch(rnd_num)
			{

				case PART_TIME:
				{
						empHour = 4;
						break;
				}

				case FULL_TIME:
				{
						empHour = 8;
						break;
				}

				 default:
				{
						empHour = 0;
						break;
				}


			}

			wage = empHour * RATE_PER_HOUR;
			Console.WriteLine($"UC-4 Wage of Employee is {wage}");
			return wage;

        }


		public int MonthlyWage()
		{
            //const int PART_TIME = 1;
            //const int FULL_TIME = 2;
            
            //const int RATE_PER_HOUR = 20;
            //const int TOTAL_WORKING_DAY = 20;
            int empHour = 0;
            int totalHours = 0;
            int wage;
            int day;

			for(day = 1; day<=TOTAL_WORKING_DAY; day++)
			{
                Random rnd = new Random();
                int rnd_num = rnd.Next(0, 3);

                switch (rnd_num)
                {

                    case PART_TIME:
                        {
                            empHour = 4;
                            break;
                        }

                    case FULL_TIME:
                        {
                            empHour = 8;
                            break;
                        }

                    default:
                        {
                            empHour = 0;
                            break;
                        }


                }

                totalHours +=empHour;
            }

			wage = totalHours * RATE_PER_HOUR;

			Console.WriteLine($"UC5- Total Wage for {day - 1} is {wage}");
			return wage;



        }


		public int TotalWage()
		{

            //const int PART_TIME = 1;
            //const int FULL_TIME = 2;

            //const int RATE_PER_HOUR = 20;
            //const int TOTAL_WORKING_DAY = 20;
            int empHour = 0;
            int totalHours = 0;
            int wage;
            int day=1;

            while(totalHours<=100 && day<=20)
            {
                Random rnd = new Random();
                int rnd_num = rnd.Next(0, 3);

                switch (rnd_num)
                {

                    case PART_TIME:
                        {
                            empHour = 4;
                            break;
                        }

                    case FULL_TIME:
                        {
                            empHour = 8;
                            break;
                        }

                    default:
                        {
                            empHour = 0;
                            break;
                        }


                }

                totalHours += empHour;
                day++;
            }

            wage = totalHours * RATE_PER_HOUR;

            Console.WriteLine($"UC6- Total Wage for {day-1} is {wage}");
            return wage;


        }


    }



}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class ConditionalWorking
    {
        public static void ConditionalTotalHOurWage()
        {
            string type = "";
            int PerDailyWage = 20;
            int WorkingDay = 20;
            int DailyHour = 0;
            int TotalHrs = 0;
            int THours = 100;
            int i = 0;
            while (i<=WorkingDay && i <= THours)
            {
                i++;
                Random random = new Random();
                int num = random.Next(3);
                switch (num)
                {
                    case 1:
                        type ="FullTimeJob";
                        DailyHour = 8;
                        break;

                    case 2:
                        type ="PartTimeJob";
                        DailyHour = 4;
                        break;

                    default:

                        type = "Absent";
                        DailyHour = 0;
                        break;
                }
                TotalHrs = TotalHrs + DailyHour;
                Console.WriteLine("employee is {0}  and total hour is {1}", type, TotalHrs);
            }
            int TotalMonthWage = TotalHrs*PerDailyWage;
            Console.WriteLine("total month salary {0}", TotalMonthWage);

        }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class MonthlyWage
    {
        public static void MonthlyEmployeeWage()
        {
            string type = "";
            int PerDailyWage = 20;
            int WorkingDay = 20;
            int DailyHour = 0;
            int TotalHrs = 0;
            for (int i =1; i<=WorkingDay; i++)
            {
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
                Console.WriteLine("employee is {0}  and total hour working day is {1}", type, TotalHrs);
            }
            int TotalMonthWage = TotalHrs*PerDailyWage;
            Console.WriteLine("total month salary {0}" , TotalMonthWage);
            
        }

    }
}

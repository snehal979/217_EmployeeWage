using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class MethodEmployee
    {
        public static void employeewithParameter(string company ,int PerDailyWage ,int WorkingDay,int THours)
        {
            string type = "";
            int DailyHour = 0;
            int TotalHrs = 0;
            
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
               
            }
            int TotalMonthWage = TotalHrs*PerDailyWage;
            Console.WriteLine("{0} total month salary {1}",company, TotalMonthWage);

        }
       


    }
}


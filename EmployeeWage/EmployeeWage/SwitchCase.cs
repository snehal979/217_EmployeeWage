using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class SwitchCase
    {
        public static void  FullORpartTimeWithSwitch()
        {
            Random random = new Random();
            int num = random.Next(3);

            string type = "";
            int PerDailyWage = 20;
            int DailyHour = 0;

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
            int dailyWage = DailyHour * PerDailyWage;
            Console.WriteLine("employee is {0}  and daily wage is {1}", type, dailyWage);
        }
        
    }
}

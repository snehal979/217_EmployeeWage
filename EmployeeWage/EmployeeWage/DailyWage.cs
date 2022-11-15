using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class DailyWage 
    {
        public static void DailyEmployeeWage()
        {
            Random random = new Random();
            int num = random.Next(2);
            string type = "";
            int PerDailyWage = 20;
            int DailyHour=0;
            if (num == 0)
            {
                type = "Absent";
                DailyHour = 0;

            }
            else 
            {
                type ="FullTimeJob";
                DailyHour = 8;
            }
            int dailyWage = DailyHour * PerDailyWage;
            Console.WriteLine("employee is {0}  and daily wage is {1}",type, dailyWage);
        }
        public static void FullOrPartTimeWage()
        {
            Random random = new Random();
            int num = random.Next(3);
            string type = "";
            int PerDailyWage = 20;
            int DailyHour = 0;
            if (num == 1)
            {
                type ="fullTimeJob";
                DailyHour = 8;

            }
            else if (num == 2)
            {
                type ="PartTimeJob";
                DailyHour = 4;
            }
            else
            {
                type = "Absent";
                DailyHour = 0;
            }

            int dailyWage = DailyHour * PerDailyWage;
            Console.WriteLine("employee is {0}  and daily wage is {1}", type, dailyWage);
        }
    }
    
}

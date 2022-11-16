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
        
    }
    
}

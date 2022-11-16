using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class ComputerWage
    {
        // class variable
        public const int Per_hour = 20;
        public const int Full_Type_Job = 1;
        public const int Part_Type_Job = 2;

        public void CalculationMonth(int working_day, int working_hour)
        {
            int day_hour = 0;
            string type = " ";
            int total_day = 0;


            int i = 0;
            while (i < working_hour && i < working_day)
            {
                i++;

                Random random = new Random();
                int emp = random.Next(3);
                switch (emp)
                {
                    case Full_Type_Job:
                        type = "FULL TIME";
                        day_hour = 8;
                        break;

                    case Part_Type_Job:
                        type = "PART TIME";
                        day_hour = 4;
                        break;

                    default:
                        day_hour = 0;
                        break;
                }
                total_day = total_day + Per_hour;
            }
            int total_salary = total_day * day_hour;

            Console.WriteLine("the total working day salary ={0}", total_salary);

        }
    }
}


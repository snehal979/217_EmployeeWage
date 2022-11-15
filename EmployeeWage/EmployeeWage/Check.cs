using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Check
    {
        public void EmployeeIsPresentOrAbsent()
        {
            Random random = new Random();
            int num = random.Next(2);

            if(num == 0)
            {
                Console.WriteLine("employee is absent");
            } else
            {
                Console.WriteLine("employee is present");
            }


        }

        
    }
}

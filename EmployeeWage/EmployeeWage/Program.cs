using System.Xml.Serialization;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage branch");
            string Choice;

            
            do
            {
                Console.WriteLine("1-uc1 \n 2-uc2 \n 3-uc3 \n 4-uc4\n 5-uc5\n 6-uc6 \n 7.-uc7 \n 8.-uc8");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Check check = new Check();
                        check.EmployeeIsPresentOrAbsent();
                        break;
                    case 2:
                        DailyWage.DailyEmployeeWage();
                        break;
                    case 3:
                        DailyWage.FullOrPartTimeWage();
                        break;
                    case 4:
                        SwitchCase.FullORpartTimeWithSwitch();
                        break;
                    case 5:
                        MonthlyWage.MonthlyEmployeeWage();
                        break;
                    case 6:
                        ConditionalWorking.ConditionalTotalHOurWage();
                        break;
                    case 7:
                        MethodEmployee.employeewithParameter("JIO", 20, 30, 10);
                        break;
                    case 8:
                        // perCompany wage for creat the new object of company name
                        ComputerWage JIO = new ComputerWage();
                        JIO.CalculationMonth(20, 10);
                        Console.WriteLine("-----");
                         ComputerWage TATA = new ComputerWage();
                        TATA.CalculationMonth(30, 10);
                        break;
                    default:
                        Console.WriteLine("InvalidNUmber");
                        break;
                }

                Console.WriteLine("reapeat the function yes/no");
                Choice = Console.ReadLine().ToLower();

            }while (Choice == "yes");

            Console.WriteLine("end");

          
            

        }
    }
}

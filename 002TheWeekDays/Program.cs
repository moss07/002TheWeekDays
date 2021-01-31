using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002TheWeekDays
{
    class Program
    {
        #region TheWeekDays with Enum

        enum Days
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day of week between 1-7");
            byte number = byte.Parse(Console.ReadLine());
            Console.WriteLine(Enum.GetName(typeof(Days), number));

            #region TheWeekDays with Switch
            
            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday"); 
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("You chose wrong number. Please try again!");
                    break;
            }

            #endregion

            Console.ReadLine();
        }
    }
}

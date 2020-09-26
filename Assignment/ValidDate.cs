using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ValidDate
    {
        const int maximum = 9999;
        const int minimum = 1000;

        static bool isValidDate(int date, int month, int year)
        {
            if (year >= minimum && year <= maximum)
            {
                if(month >=1 && month <=12)
                {
                    if(date >=1 && date <= 31)
                    {
                        if(month == 2)
                        {
                            if(((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                            {
                                return (date <= 29);
                            }
                            else { return date <= 28; }
                        }
                        
                        if((month %2 == 0) && (month != 2) && date <=31)
                        {
                            Console.WriteLine("correct");
                        }
                        else
                        {
                            Console.WriteLine("Wrong");
                        }

                        if((month %2 != 0) && (date <= 30))
                        {
                            Console.WriteLine("Exactly correct");
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                    }
                }

            }

        return false;
        }

        // Driver code 
        public static void Main()
        {

            isValidDate(29, 02, 2018);
            isValidDate(30, 11, 2000);
        }
    }
}
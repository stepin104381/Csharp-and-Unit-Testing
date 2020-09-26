using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class isPrime
    {
        static bool isPrimeNumber(int num)
        {
            int i;
            if (num == 1)
            {
                return false;
            }

            for (i = 2; i <= num - 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            if (i == num)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            bool res = isPrimeNumber(7);
            if( res == true)
            {
                Console.WriteLine("It is a prime number");
            }
            else
            {
                Console.WriteLine("It is not a prime number");
            }

            bool res1 = isPrimeNumber(10);
            if (res1 == true)
            {
                Console.WriteLine("It is a prime number");
            }
            else
            {
                Console.WriteLine("It is not a prime number");
            }


        }
    }
}

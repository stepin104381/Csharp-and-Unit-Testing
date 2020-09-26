using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class sumOfPrime
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
            }
            return true;
        }

        static int sumOfPrimes(int num1, int num2)
        {
            int sum = 0;
            for (int i = num1; i <= num2; i++)
            {

            bool isPrime = isPrimeNumber(i);
                if (isPrime)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(sumOfPrimes(4,13));
        }
    }
}

using System;
using System.Runtime.InteropServices;
/*
Variables in c# are based on rthe common type system ofd . NET framework.
All data types in .NEt follow the guidelines defined in commono language specification
variable sin .Net are of 2 types : valuertypes,reference types
value types : primitive and are structures.

Integral types : byte(Byte) ,short(Int 16), int(Int 32), long(Int 64)
floating types : float(Single), double(Double)
Other types:char, boiolen, decimal(128 bit number)
All data types of c# are implicitly objects of thier wrapper types created in .NET. Implicitly they are all objects
.The wrapper types created in .NET. Implicitly they are all objects. The wrapper types provide the functions to perform
conversions from one type to another
*/

namespace ConsoleApp1
{
 
    class Ex02variables
    {
        static void Main(string[] args)
        {
            int value = 123;
            Console.WriteLine("the value is" + value);

            double dval = 234.345;
            Console.WriteLine("the double value is: " + dval);

            int bigInt = int.MaxValue; //we are using the wrapper class const value which gives the max value of int
            Console.WriteLine("The max value of int is: " + bigInt);
            Console.WriteLine("the range of int is {0} to {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("The range of float is {0} to {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("The range of decimal is {0} to {1}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("The range of long is {0} to {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("The range of short is {0} to {1}", short.MinValue, short.MaxValue);
            float d = 5.4f;
            Console.WriteLine("The value of d is:" + d);
            //Console.WriteLine("the range of long is ")
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Array2
    {
       static void Main(string[] args)
        {
            string[] names = new string[5];
            for(int i =0; i< names.Length; i++)
            {

                Console.WriteLine("enter the participant's name please");
                    names[i] = Console.ReadLine();
            }

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            //other way to creating array
            int[] data = { 23, 55, 66, 77, 78, 22 };
            foreach (int val in data) Console.WriteLine(val);

            //2-D array
            int[,] TwoDimension = new int[,]
            {
                {2, 3, 4},
                {2, 4, 5},
                {4, 5, 6}
            }; //3x3 array

            Console.WriteLine("the number of dimensions:" + TwoDimension.Rank);
            Console.WriteLine("the length of the first dimension:" + TwoDimension.GetLength(0));
            Console.WriteLine("the length of the second dimension:" + TwoDimension.GetLength(1));

            //to get into the matrix form
            for(int i =0; i<TwoDimension.GetLength(0);i++)
            {
                for(int j = 0; j < TwoDimension.GetLength(0); j++)
                {
                    Console.WriteLine(TwoDimension[i,j] + " " );
                }
                Console.WriteLine();
            }
        }
    }
}

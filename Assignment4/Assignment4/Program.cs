using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //first practice - 50-1 for loop

            int i;
            Console.WriteLine("Numbers 50 to 1: ");
            for (i = 50; i > 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n*************************************************************");

            //second practice - odd number do while loop 1-50

            int index = 1;
            Console.WriteLine("\nOdd numbers from 1 to 50: ");
            do
            {
                if(index % 2 != 0)
                {
                    Console.Write(index + " ");
                }
                index++;
            } while (index<=50);
            Console.Write("\n*************************************************************");

            //third practice - even number while loop 1-50

            int j = 1;
            Console.WriteLine("\nEven numbers from 1 to 50: ");
            while (j <= 50)
            {
                if (j % 2 == 0)
                {
                    Console.Write(j + " ");
                }
                j++;
            }
            Console.Write("\n*************************************************************");

            //fourth practice - given number for loop multiplication table

            int number, size;

            Console.Write("\nPlease give a number for the table : ");
            number = Convert.ToInt32(Console.ReadLine());
            for (size = 1; size <= 10; size++)
            {
                Console.Write("{0} * {1} = {2} \n", number, size, number * size);
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //first practice - if else
            int number;
            Console.Write("Please enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if(number > 0)
            {
                Console.WriteLine("The number is positive.");
            } else
            {
                Console.WriteLine("The number is negative.");
            }


            //second practice - if elseif else
            int input;
            Console.Write("Please enter a grade: ");
            input = Convert.ToInt32(Console.ReadLine());
            if(input > 70)
            {
                Console.WriteLine("Your grade is A.");
            } else if (input > 60 && input < 70)
            {
                Console.WriteLine("Your grade is B.");
            } else if (input > 50 && input < 60) {
                Console.WriteLine("Your grade is C.");
            } else if (input > 40 && input < 50)
            {
                Console.WriteLine("Your grade is D.");
            } else
            {
                Console.WriteLine("Your grade is F.");
            }

            //third practice - switch
            int day;
            Console.Write("Please enter a day (1-7): ");
            day = Convert.ToInt32(Console.ReadLine());
            switch(day)
            {
                case 1:
                    Console.WriteLine("It is Monday.");
                    break;
                case 2:
                    Console.WriteLine("It is Tuesday.");
                    break;
                case 3:
                    Console.WriteLine("It is Wednesday.");
                    break;
                case 4:
                    Console.WriteLine("It is Thursday.");
                    break;
                case 5:
                    Console.WriteLine("It is Friday.");
                    break;
                case 6:
                    Console.WriteLine("It is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("It is Sunday.");
                    break;
                default:
                    Console.WriteLine("Null");
                    break;
            }

            //fourth practice - ternary operator
            int num;
            Console.Write("Please enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            var result = num > 0 ? "It is a positive number." : "It is a negative number.";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

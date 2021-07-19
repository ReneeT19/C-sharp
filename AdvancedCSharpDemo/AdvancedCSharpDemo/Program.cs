using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpDemo
{
    class Program
    {
        //delegate practice - declare delegate object
        public delegate void Print(int value);
        static void Main(string[] args)
        {
            //create object oftype is delegate
            Print print = PrintID; //this object has a reference of this function
            print(123);
            print = PrintSalary;
            print(20000);
            Console.ReadLine();
            //holding two functions with single delegate object
        }

        public static void PrintID(int num)
        {
            Console.WriteLine($"Your ID is: {num}");
        }
        public static void PrintSalary(int amount)
        {
            Console.WriteLine($"Your Salary is: {amount}");
        }
        //Question: what if the second function calls for a double parameter, how do you declare the delegate?
    }
}

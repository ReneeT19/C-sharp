using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpDemo
{
    class AnonymousMethodasParam
    {
        public delegate void Print(int value);

        //this method received two parameters
        public static void PrintHelperMethod(Print printDel, int value)
        {
            value++;
            printDel(value);
        }
        static void Main()
        {
            // Here anonymous method pass as 
            // a parameter in PrintHelperMethod
            PrintHelperMethod(delegate (int val)
            {
                Console.WriteLine($"Value from anonymous function is: {val}");
            }
            , 100);
            Console.ReadLine();
        }
    }
}

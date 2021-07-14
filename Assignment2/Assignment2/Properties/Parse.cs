using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Properties
{
    class Parse
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Please enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("The converted value of age is: " + age);
            Console.ReadLine();
        }
    }
}

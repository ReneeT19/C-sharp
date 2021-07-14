using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Properties
{
    class TryParse
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Please enter your age: ");
            bool check = int.TryParse(Console.ReadLine(),out age);
            Console.WriteLine("The input of age is an integer is: " + check);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Properties
{
    class ConvertType
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a char: ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("ASCII code of" + c + " is: " + ((int)c).ToString());
            Console.Write("***********");
            Console.Write("Please enter an ASCII value: ");
            int asciicode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Char of " + asciicode + " is: " + ((char)asciicode).ToString());
            Console.ReadLine();
        }
    }
}

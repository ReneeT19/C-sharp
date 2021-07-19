using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpDemo
{
    public delegate void Print(int value);
    class AnonymousMethod
    {
        static void Main()
        {
            Print print = delegate (int val)
            {
                //function body without any function name
                Console.WriteLine($"Value is : {val}");
            };
            print(100);
            Console.ReadLine();
        }

    }
}

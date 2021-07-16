using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandling
{
    class ParamDemo
    {
        static void Main()
        {
            MyMath math1 = new MyMath();
            math1.PrintMarks(10, 20, 30, 40, 50);
            Console.ReadLine();
        }
    }
}

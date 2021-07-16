using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandling
{
    class ByValAndByRef
    {
        static void Main()
        {
            MyMath math1 = new MyMath();
            int num = 99;
            Console.WriteLine(math1.Increment(num));
            Console.WriteLine(num);

            Console.WriteLine(math1.Increment(ref num));
            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}

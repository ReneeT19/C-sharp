using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandling
{
    class OptionalParam
    {
        static void Main()
        {
            MyMath math1 = new MyMath();
            Console.WriteLine($"Size={math1.Size(100,5)}");

            double result = math1.CalculateTax(1000, TaxPer2: 5);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}

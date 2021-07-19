using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMathLib;

namespace UseMyMathLibWithConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();
            int result = math.Add(20, 40, 50, 60, 80);
            Console.WriteLine($"Sum is {result}");
            Console.ReadLine();
        }
    }
}

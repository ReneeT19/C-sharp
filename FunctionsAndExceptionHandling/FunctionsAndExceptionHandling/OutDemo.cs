using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandling
{
    class OutDemo
    {
        static void Main()
        {
            MyMath math1 = new MyMath();
            int num, num1;
            Console.WriteLine(math1.MyFunction(out num, out num1, 10,20));//100
            Console.WriteLine(num);//200
            Console.WriteLine(num1);

            Console.ReadLine();
        }
    }
}

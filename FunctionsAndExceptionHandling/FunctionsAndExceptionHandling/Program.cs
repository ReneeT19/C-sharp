using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object to call the add function in mymath class
            MyMath math1 = new MyMath();
            math1.Add();
            int ans = math1.Add(2, 4); //store the returned value in ans
            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}

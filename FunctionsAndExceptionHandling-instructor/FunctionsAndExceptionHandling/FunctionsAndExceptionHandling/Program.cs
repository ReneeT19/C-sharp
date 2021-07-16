using System;

namespace FunctionsAndExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math1 = new MyMath();
            math1.Add();
           int ans= math1.Add(20, 40);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}

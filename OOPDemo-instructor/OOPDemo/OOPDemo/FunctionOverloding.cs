using System;

namespace OOPDemo
{
    class FunctionOverloding
    {
        static void Main()
        {
            MyMath m1 = new MyMath();
            Console.WriteLine(m1.Add(30, 40));
           Console.WriteLine( m1.Add("Hello ","World"));
            Console.ReadLine();
        }
    }
}

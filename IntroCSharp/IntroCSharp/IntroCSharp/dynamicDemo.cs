using System;

namespace IntroCSharp
{
    class dynamicDemo
    {
        static void Main()
        {
            Object myobj = 40;
            dynamic num=56;//it is used to avoid compile-time type checking
            dynamic str = "welcome";
            Console.WriteLine($"type of num is {num.GetType()} type of myobj is {myobj.GetType()}");
            Console.ReadLine();
        }
    }
}

using System;


namespace IntroCSharp
{
    class IsKeywordDemo
    {
        static void Main()
        {
            B b1 = new B();
            A a1 = new A();
            Console.WriteLine($"{b1 is A}");
            Console.WriteLine($"{a1 is B}");
            Console.ReadLine();
        }
    }
    class A
    {

    }
    class B:A
    {

    }
}

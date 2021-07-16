using System;


namespace FunctionsAndExceptionHandling
{
    class ParamDemo
    {
        static void Main()
        {
            MyMath math1 = new MyMath();
         
            math1.PrintMarks(10, 30, 40, 30, 90);
            Console.ReadLine();
        }
    }
}

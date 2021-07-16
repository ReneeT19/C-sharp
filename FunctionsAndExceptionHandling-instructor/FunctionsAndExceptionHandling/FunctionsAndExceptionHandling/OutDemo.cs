using System;


namespace FunctionsAndExceptionHandling
{
    class OutDemo
    {
        static void Main()
        {
            MyMath math1 = new MyMath();
            int num,num1;
         Console.WriteLine(math1.MyFunction(out num,out num1,10,20));
            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections;


namespace ArraysAndCollections
{
    class StackDemo
    {
        static void Main()
        {
            Stack stk = new Stack();
            stk.Push(123);
            stk.Push(124);
            stk.Push(125);
            stk.Push(126);
            stk.Push("abc");
            Console.WriteLine($"Count is:{stk.Count}");
            foreach(var temp in stk)
            {
                Console.WriteLine(temp);
            }

            Console.WriteLine($"{ stk.Pop()} is removed");
            Console.WriteLine($"{stk.Peek()} is to be removed next"); 
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ArraysAndCollections
{
    class StackDemo
    {
        static void Main()
        {
            //LIFO
            Stack stk = new Stack();
            stk.Push(123);
            stk.Push(124);
            stk.Push(125);
            stk.Push(126);
            Console.WriteLine($"Count is: {stk.Count}");
            // Console.WriteLine($"{stk.Dequeue()} is removed");
            foreach (var temp in stk)
            {
                Console.WriteLine($"{temp}");
            }

        }
    }
}

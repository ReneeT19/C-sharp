using System;
using System.Collections;

namespace ArraysAndCollections
{
    class QueueDemo
    {
        static void Main()
        {
            Queue q = new Queue();
            q.Enqueue(123);
            q.Enqueue(124);
            q.Enqueue(125);
            q.Enqueue(126);
            Console.WriteLine($"count is {q.Count}");
            foreach (var temp in q)
            {
                Console.WriteLine($"{temp}");
            }
            Console.WriteLine($"{q.Dequeue()} is removed");
            foreach (var temp in q)
            {
                Console.WriteLine($"{temp}");
            }

            Console.WriteLine($"{q.Peek()} to be removed next");
            
           if(q.Contains(125))
            {
                Console.WriteLine("125 is exist");
            }
            else
            {
                Console.WriteLine("125 is not exist");
            }
            Console.ReadLine();
        }
    }
}

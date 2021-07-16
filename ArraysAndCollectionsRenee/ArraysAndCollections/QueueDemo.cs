using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArraysAndCollections
{
    class QueueDemo
    {
        static void Main()
        {
            //FIFO
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            Console.WriteLine($"Count is: {q.Count}");
            foreach (var temp in q)
            {
                Console.WriteLine($"{temp}");
            }
            Console.WriteLine($"{q.Dequeue()} is removed");
            foreach (var temp in q)
            {
                Console.WriteLine($"{temp}");
            }

            Console.WriteLine($"{q.Peek()} to be removed next.");

            if (q.Contains(2))
            {
                Console.WriteLine($"2 exists");
            }
            else
            {
                Console.WriteLine($"2 doesn't exist.");
            }
            Console.ReadLine();
        }
    }
}

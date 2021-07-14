using System;

namespace DecisionMakingConstructs
{
    class GotoDemo
    {
        static void Main()
        {
            int x = 0;
 start:     if (x <= 10)
            {
                Console.WriteLine(x);
                x++;
                goto start;
            }
            Console.ReadLine();
        }
    }
}

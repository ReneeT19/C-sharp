using System;

namespace DecisionMakingConstructs
{
    class ifelseifDemo
    {
       static void Main()
        {
            Console.Write("Enter a number for Month(1-12):");
            int no =int.Parse( Console.ReadLine());
            if (no == 1)
            {
                Console.WriteLine("Jan");
            }
            else if (no == 2)
            {
                Console.WriteLine("Feb");
            }
            else if (no == 3)
            {
                Console.WriteLine("Mar");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            Console.ReadLine();
        }
    }
}

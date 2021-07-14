using System;


namespace DecisionMakingConstructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter your Age (in Years):");
            int Age =int.Parse( Console.ReadLine());
            if (Age >= 18)
            {
                Console.WriteLine("You are a major person");
            }
            else
            {
                Console.WriteLine("You are a minor person");
            }
            Console.ReadLine();
        }
    }
}

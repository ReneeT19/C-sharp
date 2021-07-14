using System;


namespace DecisionMakingConstructs
{
    class TernaryDemo
    {
        static void Main()
        {
            Console.Write("Please Enter your Age (in Years):");
            int Age = int.Parse(Console.ReadLine());

          string result=  Age>=18 ? "You are a major person" : "You are a minor person";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

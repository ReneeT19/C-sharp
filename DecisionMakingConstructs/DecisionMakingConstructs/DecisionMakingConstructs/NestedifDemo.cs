using System;


namespace DecisionMakingConstructs
{
    class NestedifDemo
    {
        static void Main()
        {
            Console.Write("Enter higher qualification (UG/PG):");
            string Qualification = Console.ReadLine();
            Console.Write("Enter professional experience (in Months):");
            int months = int.Parse(Console.ReadLine());

            if (Qualification == "PG")
            {
                if (months >= 12)
                {
                    Console.WriteLine("You are eligible for interview");
                }
                else
                {
                    Console.WriteLine("Experience must be greater than 12 months");
                }
            }
            else
            {
                Console.WriteLine("Qualification should be PG");
            }
            Console.ReadLine();
        }
    }
}

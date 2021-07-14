using System;


namespace DecisionMakingConstructs
{
    class ShortCircDemo
    {
        static void Main()
        {
            Console.Write("Enter higher qualification (UG/PG):");
            string Qualification = Console.ReadLine();
            Console.Write("Enter professional experience (in Months):");
            int months = int.Parse(Console.ReadLine());

            if(Qualification=="PG" || months >= 18)
            {
                Console.WriteLine("You are eligible for interview");
            }
            else
            {
                Console.WriteLine("You are not eligible for interview");
            }
            Console.ReadLine();
        }
    }
}

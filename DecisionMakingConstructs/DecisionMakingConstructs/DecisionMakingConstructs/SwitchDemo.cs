using System;


namespace DecisionMakingConstructs
{
    class SwitchDemo
    {
        static void Main()
        {
            string response = "Y";
start:      Console.Write("Enter a number for Month(1-12):");
            int no = int.Parse(Console.ReadLine());
            switch (no)
            {
                case 1: Console.WriteLine("Jan");
                    break;
                case 2: Console.WriteLine("Feb");
                    break;
                case 3: Console.WriteLine("Mar");
                    break;
                case 4: Console.WriteLine("Apr");
                    break;
                default: Console.WriteLine("Invalid number");
                    break;
            }
            Console.WriteLine("do you want to continue?(Y/N)");
            response = Console.ReadLine();
            if (response == "Y")
            {
                goto start;
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMakingConstructs
{
    class Ternary
    {

        static void Main()
        {
            Console.Write("Please Enter Your Age (in years):");
            int Age = int.Parse(Console.ReadLine());
            
            string result = Age>=18? "Older than 18":"you are not old enough";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

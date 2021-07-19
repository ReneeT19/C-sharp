using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpDemo
{
    class NullableDemo
    {
        static void Main()
        {
            //Nullable<int> i = null;
            //int? i = null; //an alternative to the line above
            //Console.WriteLine(i.Value);

            //i = 20;
            //if(i.HasValue)
            //{
            //    Console.WriteLine(i);
            //} else
            //{
            //    Console.WriteLine("it is null");
            //}

            int? i = null;
            i = 20;
            int j = i ?? 0; //if i has a null value (i?), assign/erturn 0 (?0); else return 20
            Console.WriteLine(j);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArraysAndCollections
{
    class ArrayListDemo
    {
        static void Main()
        {
            ArrayList std = new ArrayList();
            std.Add(100);
            std.Add("Scott");
            std.Add('M');
            std.Add(true);
            std.Add("I");
            Console.WriteLine($"Count is: {std.Count} and capacity is: {std.Capacity}"); // when count is 5 capacity is 4*2
            std.Remove("Scott");
            Console.WriteLine("After removing element Scott");
            foreach(var temp in std)
            {
                Console.WriteLine($"{temp}");
            }
            if(std.Contains(100))
            {
                Console.WriteLine("100 exists");
            } else
            {
                Console.WriteLine("100 doesn't exist");
            }

            std.Clear();
            Console.WriteLine($"After clearing");
            Console.WriteLine($"Count is: {std.Count} and capacity is: {std.Capacity}");

            Console.ReadLine();
        }
    }
}

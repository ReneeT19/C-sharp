using System;
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
            std.Capacity = std.Count;
            Console.WriteLine($"Count is:{std.Count} and Capacity is:{std.Capacity}");
            
            std.Remove("Scott");
            std.Capacity = std.Count;
            Console.WriteLine("After removing element Scott");
            Console.WriteLine($"Count is:{std.Count} and Capacity is:{std.Capacity}");
            foreach (var temp in std)
            {
                Console.WriteLine($"{temp}");
            }

            if (std.Contains(100))
            {
                Console.WriteLine("100 is exist");
            }
            else
            {
                Console.WriteLine("100 is not exist");
            }

            std.Clear();
            Console.WriteLine("After clearing");
            Console.WriteLine($"Count is:{std.Count} and Capacity is:{std.Capacity}");
            Console.ReadLine();
        }
    }
}

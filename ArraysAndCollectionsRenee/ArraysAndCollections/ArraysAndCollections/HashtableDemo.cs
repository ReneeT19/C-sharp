using System;
using System.Collections;

namespace ArraysAndCollections
{
    class HashtableDemo
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("HDD", 12243445);
            ht.Add("RAM", 3435435435);
            ht.Add("MONITOR", 56546546);
            ht.Add("MOUSE",6546546);
            
            Console.WriteLine($"Count is {ht.Count}");
            Console.WriteLine($"Ram code is: {ht["RAM"]}");
            ht["MONITOR"] = 756456546;
            Console.WriteLine($"Monitor code is: {ht["MONITOR"]}");

           foreach(var key in ht.Keys)
            {
                Console.WriteLine($"Key={key} and Value={ht[key]}");
            }
            ht.Remove("HDD");
            Console.WriteLine("After removing HDD");

            foreach (var key in ht.Keys)
            {
                Console.WriteLine($"Key={key} and Value={ht[key]}");
            }
            Console.WriteLine();
            SortedList sorted = new SortedList();
            sorted.Add(20,"abc");
            sorted.Add(2,"xyz");
            sorted.Add(1,"sdfdsf");
            foreach (var key in sorted.Keys)
            {
                Console.WriteLine($"Key={key} and Value={sorted[key]}");
            }
            Console.ReadLine();
        }
    }
}

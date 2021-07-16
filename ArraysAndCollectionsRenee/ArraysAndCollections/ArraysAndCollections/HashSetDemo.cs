using System;
using System.Collections.Generic;


namespace ArraysAndCollections
{
    class HashSetDemo
    {
        static void Main()
        {
            HashSet<int> hash = new HashSet<int>();
            hash.Add(10);
            hash.Add(20);
            hash.Add(10);

            foreach(var temp in hash)
            {
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }
    }
}

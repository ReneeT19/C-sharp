using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollections
{
    class TraversDemo
    {
        static void Main()
        {
            string[] names = { "A", "B", "C", "D", "E" };
            //for(int i = 0; i <names.Length; i++)
            //{
            //    Console.Write($"{names[i]}\t");
            //}
            foreach(string temp in names)
            {
                Console.Write($"{temp}\t");
            }
            Console.ReadLine();
        }
    }
}

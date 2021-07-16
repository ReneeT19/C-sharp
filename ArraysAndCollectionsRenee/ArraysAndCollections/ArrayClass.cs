using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollections
{
    class ArrayClass
    {
        static void Main()
        {
            int[] nums = { 23, 11, 2, 7, 8, 30 };
            int[] dums = new int[6];
            int[,] mynums = new int[2, 3];

            nums.CopyTo(dums, 0);
            Console.WriteLine("After Copy elements from nums to dums:");
            foreach(var temp in dums)
            {
                Console.Write($"{temp}\t");
            }
            dums.SetValue(99, 4);
            // dums[4] = 99; //this gives the same result as setvalue
            Console.WriteLine($"After settig 99 at index 4: {dums.GetValue(4)} {dums[4]}"); //get value at index 4 which is 99
            Console.WriteLine($"Upperbound of array dums is: { dums.GetUpperBound(0)} and Lowerbound is: {dums.GetLowerBound(0)}");//length-1 = upperbound; only 1 row so use 0
            Console.WriteLine($"Upperbounf of array mynums is: {mynums.GetUpperBound(0)} and {mynums.GetUpperBound(1)}"); //row 0 has 1 as upperbound (2-1)
            Console.WriteLine($"Length of mynums row is: {mynums.GetLength(0)} and column is: {mynums.GetLength(1)}");
            Console.WriteLine($"Rank for mynums  is: {mynums.Rank}"); //it shows 2 meaning 2 dimension
            Console.WriteLine($"Type of an array is: {mynums.GetType()}");

            //use static methods by using array. directly
            Array.Sort(dums);
            Console.WriteLine($"After sorting dums: ");
            foreach (var temp in dums)
            {
                Console.Write($"{temp}\t");
            }
            Console.WriteLine();

            Array.Reverse(dums);
            Console.WriteLine("After reversing dums: ");
            foreach (var temp in dums)
            {
                Console.Write($"{temp}\t");
            }
            Console.WriteLine();
            Console.WriteLine($"Index of value 99 is {Array.IndexOf(dums, 99)}");
            Array.Clear(dums, 0, 5);
            Console.WriteLine($"After Clearing first five elements");
                        Console.WriteLine();
            foreach (var temp in dums)
            {
                Console.Write($"{temp}\t");
            }

            Console.ReadLine();
        }
    }
}

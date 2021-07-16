using System;


namespace ArraysAndCollections
{
    class ArrayClass
    {
        static void Main()
        {
           
            int[] nums = { 23,11,2,7,8,30};
            int[] dums = new int[6];//{ 23,11,2,7,99,30}
            int[,] mynums = new int[2,3];
            nums.CopyTo(dums, 0);
            Console.WriteLine("After Copying elements from nums to dums:");
            foreach(var temp in dums)
            {
                Console.WriteLine($"{temp}\t");
            }
            dums.SetValue(99, 4);
            dums[4] = 99;
            Console.WriteLine($"After setting 99 at index 4: {dums.GetValue(4)} {dums[4]}");
            Console.WriteLine($"Upperbound of array dums is:{dums.GetUpperBound(0)} and Lowebound is {dums.GetLowerBound(0)}");
            Console.WriteLine($"Upperbound of an array mynums is {mynums.GetUpperBound(0)} and {mynums.GetUpperBound(1)}");
            Console.WriteLine($"Length of mynums for row is :{mynums.GetLength(0)} and for column is:{mynums.GetLength(1)}");
            Console.WriteLine($"Rank for mynums is:{mynums.Rank}");
            Console.WriteLine($"Type of an array is:{mynums.GetType()}");

            Array.Sort(dums);
            Console.WriteLine($"After sorting dums:");
            foreach (var temp in dums)
            {
                Console.Write($"{temp}\t");
            }
            Console.WriteLine();

            Array.Reverse(dums);
            Console.WriteLine("After reversing dums:");
            foreach (var temp in dums)
            {
                Console.Write($"{temp}\t");
            }

            Console.WriteLine($"index of value 99 is {Array.IndexOf(dums,99)}");
            Array.Clear(dums, 0, 5);
            Console.WriteLine("After Clearing first five elements");
            foreach (var temp in dums)
            {
                Console.Write($"{temp}\t");
            }
            Console.ReadLine();
        }
    }
}

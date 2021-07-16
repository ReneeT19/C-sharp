using System;


namespace ArraysAndCollections
{
    class JaggedArray
    {
        static void Main()
        {
            int[][] nums = new int[2][];
            nums[0] = new int[3] { 11, 22, 33 };
            nums[1] = new int[2] {44,55 };


            for(int i = 0; i < 2; i++)
            {
                foreach(var temp in nums[i])
                {
                    Console.Write($"{temp}\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

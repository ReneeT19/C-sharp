using System;


namespace ArraysAndCollections
{
    class MultiDimArray
    {
        static void Main()
        {
            int[,] nums = { {11,22,33 },{44,55,66 } };
            int[,] mynums = new int[2,3];
            mynums[0, 0] = 10;
            mynums[0, 1] = 20;
            mynums[0, 2] = 30;
                
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{nums[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

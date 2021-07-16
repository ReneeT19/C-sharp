using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollections
{
    class JaggedArray
    {
        static void Main()
        {
            //jagged array is called array of array
            int[][] nums = new int[2][];
            nums[0] = new int[] { 11, 22, 33 }; //fist row 3 columns
            nums[1] = new int[] { 44, 55 }; //second row 2 columns

            for(int i = 0; i<2; i++)
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

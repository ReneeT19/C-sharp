using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollections
{
    class MultiDimArray
    {
        static void Main()
        {
            int[,] nums = { { 1, 2, 3 }, { 4, 5, 6 } };  //first is row, second is column
            int[,] mynums = new int[2, 3]; //2 rows, 3 columns
            mynums[0, 0] = 10;
            mynums[0, 1] = 20;
            mynums[0, 2] = 30;

            //need two for loops for 2-d array
            for(int i = 0; i<2; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    Console.Write($"{mynums[i, j]}\t");
                }
                Console.WriteLine(); //blank line
            }
               Console.ReadLine();
        }
    }
}

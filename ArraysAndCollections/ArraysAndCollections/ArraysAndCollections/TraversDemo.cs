using System;


namespace ArraysAndCollections
{
    class TraversDemo
    {
        static void Main()
        {
            string[] names = {"Scott","Tiger","Smith","Jhones","Marry" };
            //for(int i = 0; i < (names.Length); i++)
            //{
            //    Console.Write($"{names[i]}\t");
               
            //}

            foreach(var temp in names)
            {
                Console.Write($"{temp}\t");
            }
            Console.ReadLine();
        }
    }
}

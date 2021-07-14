using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingConstructs
{
    class Program
    {
        static void Main(string[] args)
        {
           // for(int i=0; i<=10; i++)
           // {
           //     Console.WriteLine(i);
           // }

            //int sum = 0;
            //for(int i = 1; i <= 15; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine($"{sum}");
            //Console.ReadLine();

            int num = 0;
            int index = 16;
            //while(index <= 15)
            //{
            //    num = num + index;
            //    Console.WriteLine($"{sum}");
            //    index++;
            //}
            //Console.ReadLine();

            do
            {
                num = num + index;
                Console.WriteLine($"{num}");
            } while (index <= 15);
            //Console.ReadLine();

            int[] numbers = { 10, 20, 30, 40, 50 };
            foreach(int temp in numbers)
            {
                Console.WriteLine($"{temp}");
            }
            Console.WriteLine("*********");
            for(int i=0; i<=4;i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }
    }
}

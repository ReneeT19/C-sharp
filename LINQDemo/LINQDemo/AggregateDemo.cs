using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class AggregateDemo
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };
            var count = numbers.Count();
            var countGT10 = numbers.Count(num => num > 10);
            var max = numbers.Max();
            var min = numbers.Min();
            var avg = numbers.Average();
            var sum = numbers.Sum();
            Console.WriteLine($"count={count}\ncount greater than 10={countGT10}\nmax={max}\nmin={min}\naverage={avg}\nsum={sum}");
            Console.ReadLine();
        }

    }
}

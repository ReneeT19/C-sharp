using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureAndEnum
{
    class ShowEnum
    {
        static void Main()
        {
            Console.WriteLine($"Department name={Dept.HR} and Value={Dept.HR.GetHashCode()}");
            Console.WriteLine($"Department name={Dept.HR} and Value={Convert.ToInt32(Dept.HR)}");

            foreach(var value in Enum.GetValues(typeof(Dept)))
            {
                Console.WriteLine($"Name={value} and Value={value.GetHashCode()}");
            }

            foreach(var val in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine($"Name={val} and Value={val.GetHashCode()}");
            }
            Console.ReadLine();
        }
    }
}

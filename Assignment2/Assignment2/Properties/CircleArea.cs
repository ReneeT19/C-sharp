using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Properties
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.Write("Please enter the radius of the circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = radius * radius * Math.PI;
            Console.WriteLine("The Area of circle is: " + area);
            Console.ReadLine();
        }
    }
}

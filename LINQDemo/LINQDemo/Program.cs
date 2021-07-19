using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> courselist = new List<String>()
            {
                "C# Tutorials", "VB.NET Tutorials", "Learn C++", "MVC Tutorials", "Java"
            };
            //var result = from course in courselist where course.Contains("Tutorials") select course;
            var result1 = courselist.Where(course => course.Contains("Tutorials")); //anonymous method

            foreach(var course in result1)
            {
                Console.WriteLine(course);
            }
            Console.ReadLine();
        }
    }
}

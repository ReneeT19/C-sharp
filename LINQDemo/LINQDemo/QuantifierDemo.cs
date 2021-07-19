using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class QuantifierDemo
    {
        static void Main()
        {
            List<Student> studentlist = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "A", Age = 15 },
                new Student() { StudentID = 2, StudentName = "B", Age = 20 },
                new Student() { StudentID = 3, StudentName = "C", Age = 18 },
                new Student() { StudentID = 4, StudentName = "D", Age = 20 },
                new Student() { StudentID = 5, StudentName = "E", Age = 15 }
            };

            var areAllTeen = studentlist.All(std => std.Age > 12 && std.Age < 20);
            Console.WriteLine(areAllTeen ? "all are teenagers" : "all are not teenagers");

            var isAnyTeen = studentlist.Any(std => std.Age > 12 && std.Age < 20);
            Console.WriteLine(isAnyTeen ? "there is teenager" : "No teenagers");

            Console.ReadLine();
        }
    }
}

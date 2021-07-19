using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class WhereDemo
    {
        static void Main()
        {
            //create a list of students
            List<Student> studentlist = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "A", Age = 20 },
                new Student() { StudentID = 2, StudentName = "B", Age = 17 },
                new Student() { StudentID = 3, StudentName = "C", Age = 23 },
                new Student() { StudentID = 4, StudentName = "D", Age = 21 },
                new Student() { StudentID = 5, StudentName = "E", Age = 18 }
            };

            //find students age older than 20
            //var result = from std in studentlist where std.Age > 20 select std;
            //var result = from std in studentlist where std.Age > 20 select new { std.Age, std.StudentName };
            var result = studentlist.Where(std => std.Age >= 20); //lambda expression

            foreach (var std in result)
            {
                //Console.WriteLine($"ID={std.StudentID} Age={std.Age} Name={std.StudentName}");
                Console.WriteLine($"Age={std.Age} Name={std.StudentName}");

            }
            Console.ReadLine();
        }
    }
}

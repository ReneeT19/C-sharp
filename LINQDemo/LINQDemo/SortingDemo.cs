using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class SortingDemo
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

            var OrderByResult = from std in studentlist orderby std.StudentName select std;
            var OrderByResult2 = from std in studentlist orderby std.StudentName descending select std;

            var SortInAsc = studentlist.OrderBy(std => std.StudentName); //use OrderBy method for lambda expression
            var SortInDsc = studentlist.OrderByDescending(std => std.StudentName);

            foreach (var std in OrderByResult2)
            {
                Console.WriteLine($"ID={std.StudentID} Name={std.StudentName} Age={std.Age}");
            }
            Console.ReadLine();
        }
    }
}

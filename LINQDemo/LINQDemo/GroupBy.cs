using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class GroupBy
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

            var groupedResult = from std in studentlist group std by std.Age;

            foreach(var agegrouped in groupedResult) //outer foreach loop prints the key; inner loop prints the data associated with the key
            {
                Console.WriteLine($"Age Group: {agegrouped.Key}"); //key is age
                foreach(var std in agegrouped)
                {
                    Console.WriteLine($"\tID={std.StudentID} Name={std.StudentName}");
                }
            }

            Console.ReadLine();
        }
    }
}

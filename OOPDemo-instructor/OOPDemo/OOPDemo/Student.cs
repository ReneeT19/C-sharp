using System;

namespace OOPDemo
{
   partial class Student
    {
        //school student
        public Student()
        {
            Console.WriteLine("default constructor for Student");
        }
    }

   partial class Student
    {
        //college student
        public Student(int code)
        {
            Console.WriteLine($"welcome:{code}");
        }
    }
}

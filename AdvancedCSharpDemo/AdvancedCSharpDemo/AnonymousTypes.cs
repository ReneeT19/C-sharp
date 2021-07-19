using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpDemo
{
    class AnonymousTypes
    {
        static void Main()
        {
            var std1 = new { Id = 100, Name = "ABC", Email = "abc@gmail.com" };
            Console.WriteLine($"Id={std1.Id} Name={std1.Name} Email={std1.Email} Type={std1.GetType()}");

            var students = new[]
            {
                new {Id=100,Name="A",Email="a@a.com"},
                new {Id=101,Name="B",Email="b@b.com"},
                new {Id=102,Name="C",Email="c@c.com"},
            };
            foreach(var std in students)
            {
                Console.WriteLine($"Id={std.Id} Name={std.Name} Email={std.Email}");
            }
            Console.ReadLine();
        }
    }
}

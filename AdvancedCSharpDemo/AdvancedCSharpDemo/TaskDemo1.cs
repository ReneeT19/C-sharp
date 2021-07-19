using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpDemo
{
    class TaskDemo1
    {
        static void Main()
        {
            //use start
            //Task task1 = new Task(Message);
            //task1.Start();
            //Task task2 = new Task(Message1);
            //task2.Start();

            //use run
            //Task task3 = Task.Run(Message);
            //Task task4 = Task.Run(Message1);

            //run tasks sequentially
            //Task task1 = new Task(Message);
            //task1.Start();
            //task1.Wait();
            //Task task2 = new Task(Message1);
            //task2.Start();

            //use anonymous function in the Task Generic type tu return from Task
            //var t = Task<int>.Run(() =>
            //{
            //    return Sum(); //make reusable component here by returning a function
            //});
            //Console.WriteLine($"The sum is: {t.Result}");

            //anonymous function using Employee type
            //var t = Task<Employee>.Run(() =>
            //{
            //    Employee emp = new Employee { age = 10, name = "A", email = "a@a.com" };
            //    return emp;
            //});
            //Console.WriteLine($"Age={t.Result.age} Name={t.Result.name} Email={t.Result.email}");


            //async and await
            Method1();
            Method2();

            Console.ReadLine();
        }

            public static int Sum()
            {
                int sum = 0;
                for (int i = 0; i <= 15; i++)
                {
                    sum += i;
                }
                return sum;
            }
        
        public static void Message()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Starting a Task1... {System.Threading.Tasks.Task.CurrentId}");
                Task.Delay(2000).Wait();
            }
        }
        public static void Message1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Starting a Task2... {System.Threading.Tasks.Task.CurrentId}");
                Task.Delay(2000).Wait();

            }
        }

        public static async Task Method1() //when calling Method1, you get Task object
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Method 1...value is {i} {DateTime.Now.Millisecond}");
                    Task.Delay(500).Wait();
                }
            });
        }

        public static async Task Method2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine($"Method 1...value is {i} {DateTime.Now.Millisecond}");
                    Task.Delay(500).Wait();
                }
            });
        }
    }
}

using System;
using System.Collections.Generic;

namespace ArraysAndCollections
{
    class GenericStack
    {
        static void Main()
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(20);
            // stk.Push("abc");
            Stack<string> stk1 = new Stack<string>();
            stk1.Push("abc");
            //stk1.Push(12) ;//Error
            Queue<int> q = new Queue<int>();

            Stack<Employee> empstk = new Stack<Employee>();
            Employee emp = new Employee {EmpCode=100,EmpName="Scott",Email="scott@gmail.com" };
            empstk.Push(emp);
            Employee emp1 = new Employee { EmpCode = 101, EmpName = "Tiger", Email = "tiger@gmail.com" };
            empstk.Push(emp1);

            foreach(var employee in empstk)
            {
                Console.WriteLine($"{employee.EmpCode}\t {employee.EmpName}\t {employee.Email}");
            }
            Console.ReadLine();
        }
    }
}

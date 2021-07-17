using System;

namespace OOPDemo
{
    class FunctionOverriding
    {
        static void Main()
        {
            MyMath1 m1 = new MyMath1();
            int num = 0;
            Console.WriteLine(m1.Increment(10));
            Console.WriteLine($"{m1.ToString()} {num.ToString()}");
            Employee emp = new Employee {EmpCode=100,EmpName="Scott",Email="Scott@gmail.com",DeptName="Sales" };
            Console.WriteLine(emp.ToString());
            Console.ReadLine();
        }
    }
}

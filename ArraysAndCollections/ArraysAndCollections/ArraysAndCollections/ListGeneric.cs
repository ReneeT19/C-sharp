using System;
using System.Collections.Generic;


namespace ArraysAndCollections
{
    class ListGeneric
    {
        static void Main()
        {
            Employee emp = new Employee { EmpCode = 100, EmpName = "Scott", Email = "scott@gmail.com" };
            Employee emp1 = new Employee { EmpCode = 101, EmpName = "Tiger", Email = "tiger@gmail.com" };

            List<Employee> emplist = new List<Employee>();
            emplist.Add(emp);
            emplist.Add(emp1);
            foreach(var employee in emplist)
            {
                Console.WriteLine($"{employee.EmpCode}\t {employee.EmpName}\t {employee.Email}");
            }
            Console.ReadLine();
        }
    }
}

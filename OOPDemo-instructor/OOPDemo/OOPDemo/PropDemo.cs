using System;


namespace OOPDemo
{
    class PropDemo
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.EmpCode = 100;
            emp.EmpName = "Scott";
            emp.Email = "scott@gmail.com";
            emp.DeptName = "SALES";
            //emp.CompanyName = "Microsoft"; //Error
            Console.WriteLine($"Code={emp.EmpCode} Name={emp.EmpName} Company Name={emp.CompanyName}");
            Console.ReadLine();
        }
    }
}

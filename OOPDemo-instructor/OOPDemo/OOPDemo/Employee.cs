using System;


namespace OOPDemo
{
   public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default constructor of Employee");
        }

        public Employee(int EmpCode)
        {
            Console.WriteLine($"Welcome:{EmpCode}");
        }

        private int Code;
        private string Name;
        public int EmpCode
        {
            get
            {
                Code++;
                return Code;
            }
            set
            {
                if (value > 0)
                {
                    Code = value;
                }
                else
                {
                    Console.WriteLine("Invalid EmpCode");
                }
            }
        }
        public string EmpName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return "Google";
            }
        }

        public string Email { get; set; }
        public string DeptName { get; set; }

        public override string ToString()
        {
            return $"Code={EmpCode} Name={EmpName} CompanyName={CompanyName} Email={Email} DeptName={DeptName}";
        }
    }
}

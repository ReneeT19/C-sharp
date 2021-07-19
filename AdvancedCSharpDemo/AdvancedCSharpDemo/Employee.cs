using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpDemo
{
    [Serializable]
    class Employee
    {
        [NonSerialized]
        private int Age;

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
        public string name { get; set; }
        public string email { get; set; }

        //Employee()
        //{
        //    Console.WriteLine("Constructor Called");
        //}
        //Employee(int age, string name, string email)
        //{
        //    this.age = age;
        //    this.name = name;
        //    this.email = email;
        //}
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AdvancedCSharpDemo

{
    class SerDeSerDemo
    {
        static void Main()
        {
            DoSerialization();
            DoDeserialization();
            Console.ReadLine();
        }

        public static void DoSerialization()
        {
            Employee emp = new Employee() {age = 35, name = "A", email = "a@a.com" };
            FileInfo f = new FileInfo(@"employee.dat");
            Stream stream = f.Open(FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(stream, emp);
            stream.Close();
            Console.WriteLine("Object is Serialized Successfully");
        }
        public static void DoDeserialization()
        {
            Employee emp = new Employee();
            FileInfo file = new FileInfo(@"employee.dat");
            Stream stream = file.Open(FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            emp = (Employee) b.Deserialize(stream);
            Console.WriteLine($"name={emp.name} age={emp.age} email={emp.email}");
            stream.Close();
        }
    }
}

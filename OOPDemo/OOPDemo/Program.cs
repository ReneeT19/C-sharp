using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone m = new MobilePhone();
            Console.WriteLine(m.Calling());
            Console.WriteLine(m.SendSMS());
            Console.ReadLine();
        }
    }
}

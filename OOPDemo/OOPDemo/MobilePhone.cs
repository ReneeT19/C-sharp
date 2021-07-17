using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class MobilePhone
    {
        public MobilePhone()
        {
            Console.WriteLine("Default Constructor of MobilePhone");
        }
        public string Calling()
        {
            return "Calling() from MobilePhone"; 
        }
        public string SendSMS()
        {
            return "SendSMS() from MobilePhone()";
        }
    }
}

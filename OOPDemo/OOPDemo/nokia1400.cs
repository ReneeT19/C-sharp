using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class Nokia1400:MobilePhone //nokia1400 inherits from mobilephone
    {
        public Nokia1400()
        {
            Console.WriteLine("Default Constructor of Nokia1400");
        }
        public string MP3()
        {
            return "MP3() from Nokia1400";
        }
    }
}

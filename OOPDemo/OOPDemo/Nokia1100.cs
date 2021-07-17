using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class Nokia1100:Nokia1400
    {
        public Nokia1100()
        {
            Console.WriteLine("Default constructor for nokia 1100");
        }

        public string Camera()
        {
            return "Camera() from Nokia1100";
        }
    }
}

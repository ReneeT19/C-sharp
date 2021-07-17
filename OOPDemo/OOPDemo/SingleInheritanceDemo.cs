using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class SingleInheritanceDemo
    {
        static void Main()
        {
            Nokia1400 nk = new Nokia1400();
            Console.WriteLine(nk.Calling());
            Console.WriteLine(nk.SendSMS());

            Console.ReadLine();
        }
    }
}

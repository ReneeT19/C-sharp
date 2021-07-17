using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class MultiLevelInheritance
    {
        static void Main()
        {
            Nokia1100 nk = new Nokia1100();
            Console.WriteLine(nk.Calling());
            Console.WriteLine(nk.SendSMS());
            Console.WriteLine(nk.MP3());
            Console.WriteLine(nk.Camera());

            Console.ReadLine();
        }
    }
}

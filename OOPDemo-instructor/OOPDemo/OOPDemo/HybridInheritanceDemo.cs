using System;


namespace OOPDemo
{
    class HybridInheritanceDemo
    {
        static void Main()
        {
            NOKIA2700 nk = new NOKIA2700();
            Console.WriteLine(nk.Calling());
            Console.WriteLine(nk.SendSMS());
            Console.WriteLine(nk.MP4());
            Console.ReadLine();
        }
    }
}

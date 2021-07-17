using System;


namespace OOPDemo
{
    class SingleInheritanceDemo
    {
        static void Main()
        {
            NOKIA1400 nk = new NOKIA1400();
            Console.WriteLine(nk.Calling());
            Console.WriteLine(nk.SendSMS());
            Console.ReadLine();
        }
    }
}

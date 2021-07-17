using System;


namespace OOPDemo
{
    class Multilevelinheritance
    {
        static void Main()
        {
            NOKIA1100 nk = new NOKIA1100();
            Console.WriteLine(nk.Calling());
            Console.WriteLine(nk.SendSMS());
            Console.WriteLine(nk.MP3());
            Console.WriteLine(nk.Camera());
            Console.ReadLine();
        }
    }
}

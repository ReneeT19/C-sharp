using System;


namespace OOPDemo
{
    class InterfaceDemo
    {
        static void Main()
        {
            // IWIFI i = new NOKIALUMIA();
            //Console.WriteLine(i.StartWIFI());
            //Console.WriteLine(i.StopWIFI());
            // Console.WriteLine(i.ConnectWIFI());

            NOKIALUMIA nk = new NOKIALUMIA();
           Console.WriteLine( nk.Calling());
          Console.WriteLine(  nk.StartWIFI());
          Console.WriteLine(  nk.StopWIFI());
           Console.WriteLine( nk.ConnectWIFI());
           Console.WriteLine( nk.PushMessage());
            Console.ReadLine();
        }
    }
}

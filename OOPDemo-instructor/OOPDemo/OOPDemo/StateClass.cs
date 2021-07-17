using System;


namespace OOPDemo
{
  static  class StateClass
    {
        static StateClass()
        {
            Console.WriteLine("Static Constructor");
        }
        public static string Message()
        {
            return "Static Message";
        }
    }
}

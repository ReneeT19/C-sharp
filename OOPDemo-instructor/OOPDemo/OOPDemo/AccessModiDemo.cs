using System;


namespace OOPDemo
{
    class AccessModiDemo
    {
        static void Main()
        {
            //Vehicle v = new Vehicle();//Error
            TwoWheeler honda = new TwoWheeler();
           Console.WriteLine( honda.Start());
           Console.WriteLine( honda.Stop());
            Console.WriteLine(honda.Stroke());
            FourWheeler toyota = new FourWheeler();
            Console.WriteLine(toyota.Start());
           Console.WriteLine( StateClass.Message());
            Console.WriteLine(StateClass.Message());

            Student std = new Student();
            Console.ReadLine();
        }
    }
}

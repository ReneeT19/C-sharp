using System;


namespace StructureAndEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Books mybook = new Books(123, "C#4.0", "Jhone Marsh");
            Console.WriteLine(mybook.Display());
            Console.ReadLine();
        }
    }
}

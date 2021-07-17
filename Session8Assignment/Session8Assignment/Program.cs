using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //first practice
            SuperComputer sc = new SuperComputer();
            Console.WriteLine(sc.BootUp());
            Console.WriteLine(sc.ShutDown());
            MainfraimComputer mc = new MainfraimComputer();
            Console.WriteLine(mc.BootUp());
            Console.WriteLine(mc.ShutDown());
            MicroComputers mic = new MicroComputers();
            Console.WriteLine(mic.BootUp());
            Console.WriteLine(mic.ShutDown());
            Pen p = new Pen();
            Console.WriteLine(p.BootUp());
            Console.WriteLine(p.StartWriting());
            Console.WriteLine();

            //second practice
            DateTime today = DateTime.Now; 
            Room r = new Room(101, 5, "King", 3, today, 105);
            Console.WriteLine(r);
            Console.WriteLine();

            //third practice
            User user1 = new User();
            User user2 = new User();
            try
            {
                Console.Write("Enter your Id:");
                long number = int.Parse(Console.ReadLine());

                Console.Write("Enter your Name:");
                string name = Console.ReadLine();

                Console.Write("Enter your Email Id:");
                string email = Console.ReadLine();

                Console.Write("Enter your Date of Birth:");
                string dob = Console.ReadLine();
            }
            catch (Exception ex)
            {
                
            }

            Console.ReadLine();
        }
    }
}

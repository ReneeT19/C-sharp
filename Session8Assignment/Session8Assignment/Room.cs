using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8Assignment
{
    class Room
    {
        //fields
        private int Number { get; set; }
        private int Floor { get; set; }
        private string Type { get; set; }
        private int Capacity { get; set; }
        private DateTime BookedTime { get; set; }
        private double Price { get; set; }

        //default construcotr
        public Room()
        {
            Console.WriteLine("This is the default constructor of Room");
        }
        //Parametarized constructor

        public Room(int number, int floor, string type, int capacity, DateTime bookedTime, double price)
        {
            this.Number = number;
            this.Floor = floor;
            this.Type = type;
            this.Capacity = capacity;
            this.BookedTime = bookedTime;
            this.Price = price;
        }

        //toString
        public override string ToString()
        {
            return $"Number: {Number}\nFloor: {Floor}\nType: {Type}\nCapacity: {Capacity}\nBookedTime: {BookedTime}\nPrice: {Price}\n";
        }

    }
}

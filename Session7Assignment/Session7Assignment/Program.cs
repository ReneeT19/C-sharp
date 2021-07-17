using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program to create structure to maintain Student Information given as below.
	RollNo,Name,Gender,MobileNo
        a. Create constructor to initialize above fields.
        b. Print values of above fields using function. 

Write a program to maintain City Names and zip Codes using Enum.
	    a. Print all Cities in given enum.
	    b. Print all zip Codes in enum.
 *
 */
namespace Session7Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //first practice - structure
            Students st = new Students(1001, "Renee", "Female", 1234567890);
            Console.WriteLine(st.Print());
            Console.WriteLine();

            //second practice - enum
            foreach(var value in Enum.GetValues(typeof(City)))
            {
                Console.WriteLine($"City name is {value}");
            }
            foreach(var value in Enum.GetValues(typeof(City)))
            {
                Console.WriteLine($"Zip code for {value} is {value.GetHashCode()}");
            }
            Console.ReadLine();
        }
    }
}

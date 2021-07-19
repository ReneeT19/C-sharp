using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpDemo
{
    class ExtensionMethodsDemo
    {
        static void Main()
        {
            int i = 50;
            bool result = i.IsGreaterThan(100);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

        public static class IntExtension
        {
            public static bool IsGreaterThan(this int i, int value) //this means the same class
            {
                //static methods cannot be instantiated or inherited; no instance can be created
                return i > value; //if this condition is met, return true
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 20, 30, 40, 50 }; //comes from System.Array; contains one type of value
            int[] myNums = new int[] { 11, 12, 13, 14, 15 }; //declare and instantiate at one line
            int[] nums1 = new int[5]; //give the size of the array and assign values below
            nums1[0] = 30;
            nums1[1] = 40;
            nums1[2] = 50;

            string[] str = { "str1", "str2", "str3", "str4", "str5" };
            string[] myStr = new string[5];
            myStr[0] = "string1";
            myStr[1] = "string2";
            myStr[2] = "string3";

            Console.WriteLine($"Length is {nums.Length}");
            Console.ReadLine();
        }
    }
}

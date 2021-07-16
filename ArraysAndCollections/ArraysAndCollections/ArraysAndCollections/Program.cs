using System;


namespace ArraysAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int[] nums = {10,20,30,40,50 };
            int[] mynums = new int[] {11,22,33,44,55 };

            int[] nums1 = new int[5];
            nums1[0] = 30;
            nums1[1] = 40;
            nums1[2] = 50;

            string[] str = {"str1","str2","str3","str4" };
            string[] mystr =new string[5];
            mystr[0] = "string1";
            mystr[1] = "string2";

            Console.WriteLine($"Lenght is {nums.Length}");
            Console.ReadLine();
        }
    }
}

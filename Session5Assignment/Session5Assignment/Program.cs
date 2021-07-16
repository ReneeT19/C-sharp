using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Session5Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //practice 1 - sum of 1-D array
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.Write("Sum of all elements in the array is : {0}\n\n", sum);

            //practice 2 - sum of diagonal elements in an array
            int[,] arr1 = new int[3, 3];
            arr1[0, 0] = 10;
            arr1[0, 1] = 40;
            arr1[0, 2] = 50;
            arr1[1, 0] = 60;
            arr1[1, 1] = 20;
            arr1[1, 2] = 70;
            arr1[2, 0] = 80;
            arr1[2, 1] = 90;
            arr1[2, 2] = 30;
            int sum1 = 0;

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(i == j)
                    {
                        sum1 += arr1[i, j];
                    }
                }
            }
            Console.WriteLine("Sum of all diagonal elements in the array is : {0}\n", sum1);

            //practice 3 - search elements in jagged array
            int[][] nums = new int[2][];
            nums[0] = new int[3] { 11, 22, 33 };
            nums[1] = new int[2] { 44, 55 };

            for (int i = 0; i < 2; i++)
            {
                foreach (var temp in nums[i])
                {
                    Console.Write($"{temp}\t");
                }
            }
            Console.WriteLine("\nSearch for a particular value: " + nums[1][1]);
            Console.WriteLine();

            //practice 4 - listGeneric
            Product pro = new Product { ProductCode = 1, ProductName = "abc", Category = "Computer" };
            Product pro1 = new Product { ProductCode = 2, ProductName = "xxx", Category = "Phone" };

            List<Product> prolist = new List<Product>();
            prolist.Add(pro);
            prolist.Add(pro1);
            foreach (var product in prolist)
            {
                Console.WriteLine($"{product.ProductCode}\t {product.ProductName}\t {product.Category}");
            }
            Console.WriteLine();

            //practice 6 - hashtable
            Hashtable ht = new Hashtable();
            ht.Add("US", 001);
            ht.Add("China", 086);
            ht.Add("Denmark", 045);

            foreach(var key in ht.Keys)
            {
                Console.WriteLine($"Key={key} and Value={ht[key]}");
            }


            Console.ReadLine();
        }
    }
}

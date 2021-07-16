using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath cal = new MyMath();
            //factorial
            try
            {
                Console.Write("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                int ans = cal.Factorial(number);
                Console.WriteLine(ans);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I am in finally");
                GC.Collect();
            }


            //jaggedarray
            int[][] jarrays = new int[4][];
            cal.JaggedArray(jarrays);
            Console.WriteLine();

            //simple interest
            double interest = cal.SimpleInterest(2, 1000, 3);
            Console.WriteLine(interest);

            //total amount - out
            double num, num1;
            int num2;
            Console.WriteLine(cal.SimpleInterestTotal(out num, out num1, out num2, 2, 1000, 3));

            //simple interest - optional
            double interest1 = cal.SimpleInterestOptional(1000,3);
            Console.WriteLine(interest1);


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6Assignment
{
    class MyMath
    {
        //print factorial
        public int Factorial(int x)

        {
            if (x == 0)
                return 1;
            else
                return x * Factorial(x - 1);
        }

        //search in jagged array
        public void JaggedArray(params int[][] jarrays)
        {
            jarrays = new int[4][];
            jarrays[0] = new int[4] { 1, 2, 3, 4 };
            jarrays[1] = new int[3] { 11, 34, 67 };
            jarrays[2] = new int[2] { 89, 23 };
            jarrays[3] = new int[5] { 0, 45, 78, 53, 99 };
            for (int i = 0; i < 4; i++)
            {
                foreach (var jarray in jarrays[i])
                {
                    Console.Write($"{jarray}\t");
                }
            }

        }

        //Simple Interest 
        public double SimpleInterest(double rate, double balance, int year)
        {
            double interest = balance * rate * year / 100;
            return interest;
        }

        //Total Amount - out
        public double SimpleInterestTotal(out double rate, out double balance, out int year, double a, double b, int c)
        {
            rate = a;
            balance = b;
            year = c;
            double interest = balance * rate * year / 100;
            return interest;
        }

        //Simple Interest - optional
        public double SimpleInterestOptional(double balance, int year, double rate = 10)
        {
            double interest = balance * rate * year / 100;
            return interest;
        }

    }
}

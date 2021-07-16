using System;


namespace FunctionsAndExceptionHandling
{
    class MyMath
    {
        int total = 0;
        public void Add()
        {
            int num1 = 30, num2 = 40;
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }

        public int Add(int num1,int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public int Increment(int x)
        {
            x++;
            return x;
        }

        public int Increment(ref int x)
        {
            x++;
            return x;
        }

        public int MyFunction(out int x,out int x1,int a,int b)
        {
            x = a;//out param. must be assigned
            x1 = b;
            int y = 100;
            return y;
        }

        public int Size(int height,int width = 10)
        {
            return height * width;
        }

        public double CalculateTax(double ProductAmt,double TaxPer1=2,double TaxPer2=3)
         {
            double Tax1Amount = ProductAmt / 100 * TaxPer1;
            double Tax2Amount = ProductAmt / 100 * TaxPer2;
            double TotalTax = Tax1Amount + Tax2Amount;
            return TotalTax;
        }

        public void PrintMarks(params int[] marks)
        {
            foreach(var mark in marks)
            {
                Console.WriteLine(mark);
            }
        }

        public void RecursiveFun(int x)
        {
            if (x <= 10)
            {
                Console.WriteLine(x);
                x++;
                RecursiveFun(x);
            }
        }
    }
}

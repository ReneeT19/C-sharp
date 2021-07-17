using System;


namespace OOPDemo
{
    class MyMath
    {
        public int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        public string Add(string str1,string str2)
        {
            return str1 + str2;
        }

        public virtual int Increment(int x)
        {
            return ++x;
        }
    }

    class MyMath1 : MyMath
    {
        public override int Increment(int x)
        {
            x = x + 5;
            return x;
        }
        public double Add(double d1,double d2)
        {
            return d1 + d2;
        }
    }
    class MyMath2 : MyMath1
    {
        public override int Increment(int x)
        {
            x = x + 10;
            return x;
        }
    }
}

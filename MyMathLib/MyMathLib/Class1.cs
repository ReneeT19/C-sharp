using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathLib
{
    public class MyMath
    {
        public int Add(params int[] nums)
        {
            int sum = 0;
            foreach(var num in nums)
            {
                sum += num;
            }
            return sum;
        }

        public double Mul(params int[] nums)
        {
            double ans = 1;
            foreach(var num in nums)
            {
                ans *= num;
            }
            return ans;
        }
        //with params keyword, you can call method like this addTwoEach(1, 2, 3, 4, 5);
        //you can call this addTwoEach(new int[] { 1, 2, 3, 4, 5 }); with or without params; 
        //params provides a shortcut
        public int FindLargerNum(int num1, int num2)
        {
            bool bigger = false;
            if(num1 > num2)
            {
                return bigger = true;
            } else
            {
                return bigger = false;
            }
        }
    }
}

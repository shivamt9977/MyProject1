using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class MethodDemo
    {
        //sum of digit

        public int DigitSum(int num)
        {
            int sum = 0;

            while(num>0)
            {
                int r = num % 10;
                sum = sum + r;
                num = num / 10;
            }

            return sum;
        }


        static void Main(string[] args)
        {
            MethodDemo s = new MethodDemo();
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int ans = s.DigitSum(n);
            Console.WriteLine("Sum of Digit is "+ans);

        }
    }
}

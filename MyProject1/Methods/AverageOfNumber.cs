using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class AverageOfNumber
    {
        public double IsAverage(int num)
        {
            int sum = 0;
            int count = 0;
            while(num!=0)
            {
                int r = num % 10;
                sum = sum + r;
                num = num / 10;
                count++;
            }
            double avrg = sum / count;
            return avrg;
        }
        static void Main(string[] args)
        {
            AverageOfNumber a = new AverageOfNumber();
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());

           double ans= a.IsAverage(n);
            Console.WriteLine("Average is "+ans);
        }
    }
}

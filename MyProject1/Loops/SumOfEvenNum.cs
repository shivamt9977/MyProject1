using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class SumOfEvenNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the Number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while(num>0)
            {
                int r = num % 10;
                if(r%2==0)
                {
                    sum = sum + r;
                   
                }
                num = num / 10;
            }
            Console.WriteLine(sum);

        }
    }
}

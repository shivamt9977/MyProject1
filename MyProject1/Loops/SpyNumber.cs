using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class SpyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int copyNumber = num;
            int prod = 1;
            while(num>0)
            {
                int r = num % 10;
                sum = sum + r;
                num = num / 10;

            }
           // Console.WriteLine(sum);
            while(copyNumber!=0)
            {
                int r1 = copyNumber % 10;
                prod = prod * r1;
                copyNumber = copyNumber / 10;
            }
           // Console.WriteLine(prod);

            if(sum==prod)
            {
                Console.WriteLine("Number is a SPY Number");
            }
            else
            {
                Console.WriteLine("Number is Not a SPY Number");

            }
        }
    }
}

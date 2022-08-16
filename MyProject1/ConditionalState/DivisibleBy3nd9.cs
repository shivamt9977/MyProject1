using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class DivisibleBy3nd9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            if(num%3==0 && num%9==0)
            {
                Console.WriteLine("Number is Divisible by 3 & 9");
            }
            else
            {
                Console.WriteLine("Number is Not Divisible by 3 & 9");

            }
        }
    }
}

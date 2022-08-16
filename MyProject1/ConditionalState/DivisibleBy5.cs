using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class DivisibleBy5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());

            if (num % 5==0)
            {
                Console.WriteLine("Number is Divisible by 3");
            }
            else
            {
                Console.WriteLine("Number is Not Divisible by 3");

            }
        }
    }
}

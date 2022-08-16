using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class GreatestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2nd num");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3rd num");
            int num3 = int.Parse(Console.ReadLine());

            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("num1 is greatest");
            }
            else if(num2>num3 && num2>num1)
            {
                Console.WriteLine("num2 is greatest");

            }
            else
            {
                Console.WriteLine("num3 is greatest");

            }
        }
    }
}

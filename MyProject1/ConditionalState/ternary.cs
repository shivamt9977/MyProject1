using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class ternary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2nd num");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 > num2 ? num1 : num2;
            Console.WriteLine("Greater num is "+result);
        }
    }
}

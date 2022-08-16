using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class PositiveOrNegativeTernary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

            string ans = num > 0 ? "Num is Positive" : "Num is Negative";
            Console.WriteLine(ans);
        }
    }
}

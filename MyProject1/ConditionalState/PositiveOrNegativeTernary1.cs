using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class PositiveOrNegativeTernary1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

            string ans = num > 0 ? "Num is Positive" : (num < 0 ? "Num is Negative" : "Num is 0");
            Console.WriteLine(ans);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class OddOrEvenTernary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

            string ans = num%2==0 ? "Num is Even" : "Num is Odd";
            Console.WriteLine(ans);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class greatestByTernary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2nd num");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3rd num");
            int num3 = int.Parse(Console.ReadLine());

            string gr = num1 > num2 && num1 > num3 ? "Num1 is Greater" : (num2 > num3 && num2 > num1)? "Num2 is Greater" : "Num3 is Greater";
        }
    }
}

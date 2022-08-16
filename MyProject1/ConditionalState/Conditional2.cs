using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class Conditional2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Num1 is greater = " + num1);
            }
            else if(num1<num2)
            {
                Console.WriteLine("Num2 is greater = " + num2);
            }
            else
            {
                Console.WriteLine("Both numbers are Equal");

            }
        }
    }
}

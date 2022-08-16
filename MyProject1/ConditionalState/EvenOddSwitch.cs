using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class EvenOddSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());

            switch (num % 2)
            {
                case 0: Console.WriteLine(num+" is Even");
                    break;

                case 1: Console.WriteLine(num+" is Odd");
                    break;
            }

            int a = num % 2;
            Console.WriteLine(a);
        }

    }
}

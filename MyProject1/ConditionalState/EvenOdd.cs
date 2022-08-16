using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enret the Number");
            int num = int.Parse(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}

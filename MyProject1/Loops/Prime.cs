using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());

            bool isprime = true;
            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    isprime = false;
                }
            }
            if(isprime==true)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}

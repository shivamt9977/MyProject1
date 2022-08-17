using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class CheckPrime
    {
        public bool IsPrime(int num)
        {
            int i = 2;
            int count = 0;
            while(i<=num)
            {
                if(num%i==0)
                {
                    count++;
                }
                i++;
            }
            if(count==1)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        static void Main(string[] args)
        {
            CheckPrime p = new CheckPrime();
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

           bool IsAprime= p.IsPrime(num);
            if(IsAprime==true)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}

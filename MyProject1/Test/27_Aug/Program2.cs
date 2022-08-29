using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._27_Aug
{
    class Program2
    {
        //sum of even digits
        // num=123456 ; 2+4+6=12
         public void number(int n1)
        {
            int sum = 0;
            while (n1!=0)
            {
                int r = n1 % 10;
                if(r%2==0)
                {
                    sum = sum + r;
                }
                n1 = n1 / 10;
            }
            Console.WriteLine("Sum of Even Number is "+sum);
        }

        static void Main(string[] args)
        {
            Program2 even = new Program2();
            int num = int.Parse(Console.ReadLine());

            even.number(num);
        }
    }
}

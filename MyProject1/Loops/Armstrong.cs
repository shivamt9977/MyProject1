using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class Armstrong
    {
        public bool Ischeck(int num)
        {
            int copynum = num;
            int sum = 0;
            while(num>0)
            {
                int r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;

            }
            if(sum==copynum)
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
            Armstrong a = new Armstrong();
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            bool check = a.Ischeck(n);

            if(check==true)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Number is Not Armstrong");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._3_sep
{
    class TwinPrime
    {

        public void Check(int num1,int num2)
        {
            int c = 0;
            int c1 = 0;
            for(int i=2;i<=num1/2;i++)
            {
                if (num1 % i == 0)
                {
                    c++;
                }
            }
            for(int j=2;j<=num2/2;j++)
            {
                if(num2%j==0)
                {
                    c1++;
                }
            }

            if(c==0 && c1==0)
            {
                if(num2-num1==2)
                {
                    Console.WriteLine("Twin Prime");
                }
                
            }
            else
                Console.WriteLine("Not a Twin Prime");
        }


        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            TwinPrime tw = new TwinPrime();
            tw.Check(num1, num2);
          

        }
    }

}

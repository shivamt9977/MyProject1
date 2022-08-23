using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class HappyNumber
    {
        static void Main(string[] args)
        {
            int n = 1234;
            int count = 0;
             while(n!=0)
            {
                int r = n % 10;
                n = n / 10;
                if(r%2==1)
                {
                    count++;
                }
            }
             if(count%2==1)
            {
                Console.WriteLine("Happy Number");
            }
             else
            {
                Console.WriteLine("Not");
            }
        }
    }
}

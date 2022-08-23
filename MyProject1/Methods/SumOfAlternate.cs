using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class SumOfAlternate
    {
        static void Main(string[] args)
        {
            int n = 15636; // 6+6+1=13
            int count = 0;
            int sum = 0;
            while(n!=0)
            {
                int r = n % 10;
                n = n / 10;
                count++;
                if(count%2==1)
                {
                    sum = sum + r;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}

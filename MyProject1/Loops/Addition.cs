using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class Addition
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=0;i<=20;i++)
            {
                if(i%2==1)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

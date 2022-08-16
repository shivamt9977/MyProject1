using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class Sum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=0;i<=10;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}

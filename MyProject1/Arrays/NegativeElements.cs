using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class NegativeElements
    {
        static void Main(string[] args)
        {
            int[] a = { -12, 32, 34, 54, -87, 56, -45 };
            int c = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]<0)
                {
                    Console.Write(a[i]);
                    c++;
                }

            }
            Console.WriteLine("\nTotal Negative numbers : "+c);
        }
    }
}

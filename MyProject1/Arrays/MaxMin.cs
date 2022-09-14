using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class MaxMin
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 34, 44, 66, 33 };
            int max = a[0];
            int min = a[0];

            for (int i = 0; i<a.Length; i++)
            {
                if(max<a[i])
                {
                    max = a[i];
                }
                if(min>a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Max Value is "+max);
            Console.WriteLine("Max Value is "+min);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class Alternate
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 34, 44, 66, 33 };
            int[] b = { 56, 76, 34, 56, 87 };
            int[] c = new int[a.Length + b.Length];

            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[k] = a[i];
                k++;
                c[k] = b[i];
                k++;
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 25, 45, 75, 32, 26, 14 };

            int start = 0, end = a.Length - 1;
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();

            while (start<end)
            {
                int t = a[start];
                a[start] = a[end];
                a[end] = t;
                start++;
                end--;
            }
            
            for(int i=0;i<a.Length;i++)
                Console.Write(a[i]+" ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 23, 34, 45, 56, 67, 78, 89 };
            int[] b = new int[a.Length];
            int[] c = new int[a.Length];

            int k = 0;
            int l = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    b[k] = a[i];
                    k++;
                }
                else
                {
                    c[l] = a[i];
                    l++;
                }
            }

            for(int i=0;i<k;i++)
            {
                Console.Write(b[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i <l; i++)
            {
                Console.Write(c[i] + " ");
            }
        }
        
    }
}

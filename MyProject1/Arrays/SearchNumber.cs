using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class SearchNumber
    {

        static void Main(string[] args)
        {
            int[] a = { 12, 23, 34, 45, 56, 99 };
            int num = 45;
            int k = 0;
            for(int i=0;i<a.Length;i++)
            {
                

                if (a[i] == num)
                {
                    Console.WriteLine(k);

                }
                k++;
            }

        }
    }
}

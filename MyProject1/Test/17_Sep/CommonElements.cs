using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._17_Sep
{
    class CommonElements
    {
        static void Main(string[] args)
        {
            int[] a = { 15, 4, 6, 5, 10, 60, 45 };
            int[] b = { 15, 3, 98, 56, 10, 70, 35 };

            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<b.Length;j++)
                {
                    if(a[i]==b[j])
                    {
                        Console.Write(a[i]+" ");
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class InsertElement
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 34, 54, 67 };
            int num = 10;

            //insertion num in array of 2 index
            a[2] = num;
           // a[a.Length+1] = num;

            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
        }
    }
}

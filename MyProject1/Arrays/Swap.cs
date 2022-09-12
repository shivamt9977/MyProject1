using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class Swap
    {

        static void Main(string[] args)
        {
            int[] a = { 10, 23, 15, 48, 45 };

            int t = a[0];
            a[0] = a[2];
            a[2] = t;

            Console.WriteLine(a[0]);
            Console.WriteLine(a[2]);
        }
    }
}

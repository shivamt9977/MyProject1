using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class Alternate2
    {
        public void PrintArray(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] a = { 12, 34, 44, 66, 33 };
            int[] b = { 56, 76, 34, 56, 87,76,98,65 };
            int[] c = new int[a.Length + b.Length];

            int k = 0;

            for(int i=0;i<c.Length;)
            {
                if(k<a.Length && k<b.Length)
                {
                    c[i] = a[k];
                    i++;
                    c[i] = b[k];
                    i++;
                }
                else if(k<a.Length)
                {
                    c[i] = a[k];
                    i++;
                }
                else if(k<b.Length)
                {
                    c[i] = b[k];
                    i++;
                }
                k++;


               

            }
            Alternate2 aa = new Alternate2();

            // aa.PrintArray(a);
            //aa.PrintArray(b);
            aa.PrintArray(c);

        }
    }
}

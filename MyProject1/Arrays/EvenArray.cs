using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class EvenArray
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter 10 no");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int even = 0, odd = 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] % 2 == 0)
                {
                    even++;
                }
                else
                    odd++;
            }

            Console.WriteLine("Even no is "+even);
            Console.WriteLine("Odd no is " + odd);

        }
    }
}

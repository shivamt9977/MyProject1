using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ArrayDemo
    {

        static void Main(string[] args)
        {
            int[] b = new int[5];
            Console.WriteLine("5 Elements\n");

            for(int i=0;i<b.Length;i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<b.Length;i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.WriteLine("Repeat\n");

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
            
        }
    }
}

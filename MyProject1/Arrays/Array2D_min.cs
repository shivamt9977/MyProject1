using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class Array2D_min
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];
            int min;
            for (int c = 0; c < arr.GetLength(1); c++)
            {
                Console.WriteLine($"Enter {arr.GetLength(0)} Elements in {c} Column");
                for (int r = 0; r < arr.GetLength(0); r++)
                {
                    arr[c,r] = int.Parse(Console.ReadLine());
                }
            }

            for (int c = 0; c < arr.GetLength(1); c++)
            {
                min = arr[0, c];

                for (int r = 0; r < arr.GetLength(0); r++)
                {
                    if (min > arr[c, r])
                    {
                        min = arr[c, r];
                    }
                }
                Console.WriteLine("\nManimum is " + min);
            }

        }
    }
}

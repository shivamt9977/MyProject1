using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class Array2D_max
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];
            int max;
            for(int r=0;r<arr.GetLength(0);r++)
            {
                Console.WriteLine($"Enter {arr.GetLength(1)} Elements in {r} Row");
                for(int c=0;c<arr.GetLength(1);c++)
                {
                    arr[r, c] = int.Parse(Console.ReadLine());
                }
            }

            for (int r = 0; r < arr.GetLength(0); r++)
            {
                max = arr[r, 0];

                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    if(max<arr[r,c])
                    {
                        max = arr[r, c];
                    }
                }
                Console.WriteLine("\nMaximum is "+max);
            }

        }
    }
}

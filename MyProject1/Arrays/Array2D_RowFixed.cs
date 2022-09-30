using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class Array2D_RowFixed
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of  Rows");
            int rw = int.Parse(Console.ReadLine());
            int[,] arr = new int[rw, 4];

            for (int r = 0; r < arr.GetLength(0); r++)
            {
                Console.WriteLine("Enter " + arr.GetLength(1) + " elements in row " + r);
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    arr[r, c] = int.Parse(Console.ReadLine());
                }
            }

            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    Console.Write(arr[r, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

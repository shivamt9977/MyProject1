using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._17_Sep
{
    class PrimeEven
    {
        public void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int c = 0;
                for (int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        c++;
                    }
                    if (c == 0)
                    {
                        Console.Write(arr[i] + " ");
                    }

                }
            }
                for (int k = 0; k < arr.Length; k++)
                {
                    if (arr[k] % 2 == 0)
                    {
                        Console.Write(arr[k] + " ");
                    }
                }
            
            
        }
        static void Main(string[] args)
        {
            PrimeEven p = new PrimeEven();
            int[] arr = { 8, 5, 9, 7, 3, 6, 8, 13, 2, 4 };
            p.print(arr);
        }
    }
}

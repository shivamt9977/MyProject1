using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._17_Sep
{
    class _1_UnicPair
    {
        public static void pairis(int[] arr,int sum)
        {
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]+arr[j]==sum)
                    {
                        Console.WriteLine($"Pair : ({arr[i]} , {arr[j]})");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 3, 5, 6, 4, 7, 8, 9 };
            int sum = 7;

            pairis(arr, sum);
        }
    }
}

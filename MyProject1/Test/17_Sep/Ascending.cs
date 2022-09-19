using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._17_Sep
{
    class Ascending
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 34, 45, 56, 78, 98, 10, 47 };

            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._17_Sep
{
    class SecondLargest
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 45, 62, 52, 20, 41, 30, 45, 32, 10 };
            int max = arr[0];
            int min = arr[0];

            for(int i=0;i<arr.Length;i++)
            {
                if(max<arr[i])
                {
                    max = arr[i];
                }
               else if(min>arr[i])
                {
                    min = arr[i];
                }
            }
            //Console.WriteLine(max);
            //Console.WriteLine(min);

            int Secondlargest = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>Secondlargest && arr[i]<max)
                {
                    Secondlargest = arr[i]; 

                }
            }
            Console.WriteLine(Secondlargest);
        }
    }
}

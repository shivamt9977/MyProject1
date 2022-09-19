using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._17_Sep
{
    class Frequency
    {
        static bool isAlreadyPresent(int[] a, int current)
        {
            for (int i = 0; i < current; i++)
            {
                if (a[i] == a[current])
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 1, 1, 2, 8, 2, 1, 3 };

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {
                if (isAlreadyPresent(a, i) == false)
                {
                    int c = 1;
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            c++;
                        }
                    }
                    Console.WriteLine($"Frequency of{a[i]}={c}");

                }
            }
        }
    }
}

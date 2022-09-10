using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._10_sep
{
    class _9_Pattern
    {
        /*    1
             222
            33333
          44444444*/


        static void Main(string[] args)
        {
            int n = 4;
            for(int i=1;i<=n;i++)
            {
                for(int space=4;space>i;space--)
                {
                    Console.Write(" ");
                }

                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }

                for(int k=i-1;k>=1;k--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                
            }
        }
    }
}

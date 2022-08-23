using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    /*
         1
        121
       12321
      1234321
     123454321
    
     */
    class Pattern13
    {
        static void Main(string[] args)
        {
            int n = 5;
           for(int i=1;i<=n;i++)
            {
                for(int space=1;space<=n-i;space++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                for(int k=i-1;k>=1;k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();

            }

        }
    }
}

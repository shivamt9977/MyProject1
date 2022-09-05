using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._3_sep
{
    class Pattern
    {
        /* 12345
           ABCD
           123
           AB
           1
           AB
           123
           ABCD
           12345*/

        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                if(i%2==1)
                {
                    for(int j=1;j<=i;j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }

                else if(i%2==0)
                {
                    char ch = 'A';
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(ch);
                        ch++;
                    }
                    Console.WriteLine();
                }
               
            }




/*            for(int k=2;k<=5;k++)
            {
                if(k%2==0)
                {
                    char ch1 = 'A';
                    for(int l=2;l<=k;l++)
                    {
                        Console.Write(ch1);
                        ch1++;
                    }
                    Console.WriteLine();
                }
                else if(k%2==1)
                {
                    for(int m=1;m<=k; m++)
                    {
                        Console.Write(m);
                    }
                    Console.WriteLine();
                }
            }*/
        }

    }
}

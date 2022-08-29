using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class PrintPrime
    {
        static void Main(string[] args)
        {
        
            for(int j=1;j<=500;j++)
            {
                int c = 0;
                for (int k = 1; k <= j; k++)
                {
                    
                    if (j % k == 0)
                    {
                        c++;
                    }
                   
                   
                }
                if (c == 2)
                {
                    Console.WriteLine(j);

                }


            }
           
        }
    }
}

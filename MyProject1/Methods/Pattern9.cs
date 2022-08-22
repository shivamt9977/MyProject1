using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class Pattern9
    {
        /*
        5
        44
        333
        2222
        11111
        */
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}

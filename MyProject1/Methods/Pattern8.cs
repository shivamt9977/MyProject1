using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class Pattern8
    {

        /*
        8
        87
        876
        8765
        87654
         
        */
        static void Main(string[] args)
        {
            for(int i=8;i>=4;i--)
            {
                for(int j=8;j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

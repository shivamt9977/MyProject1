using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class Pattern11
    {
        /*
              1
             12
            123
           1234
          12345
         */
        static void Main(string[] args)
        {
            int lines = 5;
            for(int i=1;i<=lines;i++ )
            {
                for(int space=1;space<=lines-i;space++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                   Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

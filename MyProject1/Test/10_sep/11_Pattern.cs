using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._10_sep
{

  /*    12345
        1234
        123
        12
        1   */
    class _11_Pattern
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

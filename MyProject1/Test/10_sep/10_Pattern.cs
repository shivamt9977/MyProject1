﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._10_sep
{
    class _10_Pattern
    {
        static void Main(string[] args)
        {
          /*  *****
              ****
              ***
              ** 
              *   */


            for(int i=5;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

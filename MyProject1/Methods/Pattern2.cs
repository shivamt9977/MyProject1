﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class Pattern2
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.WriteLine("#");
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class Even1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i+" is Even");
                }
                else
                {
                    Console.WriteLine(i+" is Odd");
                }
            }
        }
    }
}

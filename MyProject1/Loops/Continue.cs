﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class Continue
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

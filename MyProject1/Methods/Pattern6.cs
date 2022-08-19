using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class Pattern6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || j == 1 || i == 5 || i==3)
                    {
                        if(i==3)
                        {
                            Console.Write("***");
                            break;
                        }
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

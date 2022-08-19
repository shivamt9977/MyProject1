using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class Pattern3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rows");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Colums");
            int c = int.Parse(Console.ReadLine());

            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if(j%2==1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("@");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

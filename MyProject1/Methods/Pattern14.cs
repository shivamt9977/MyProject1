using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class Pattern14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of lines");
            int lines = int.Parse(Console.ReadLine());

            for(int i=1;i<=lines;i++)
            {
                for(int space=1;space<=lines-i;space++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i*2-1;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

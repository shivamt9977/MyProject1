using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rows");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Colums");
            int c = int.Parse(Console.ReadLine());

            for(int i=1;i<=r;i++)
            {
                for(int j=1;j<=c;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

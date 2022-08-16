using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class Sum1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Last number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}

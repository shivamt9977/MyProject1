using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class BaseIndex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base Number");
            int bs = int.Parse(Console.ReadLine());

            Console.WriteLine("Index");
            int ind = int.Parse(Console.ReadLine());

            int c = 1;
            int ans = 1;
            while(c<=ind)
            {
                ans= ans * bs;
                c++;
            }

            Console.WriteLine(ans);
        }
    }
}

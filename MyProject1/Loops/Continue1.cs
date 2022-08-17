using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class Continue1
    {
        static void Main(string[] args)
        {
            for(int i=0;i<=20;i++)
            {
                if(i%3==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

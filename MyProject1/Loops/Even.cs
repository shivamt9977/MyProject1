using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class Even
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=18;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

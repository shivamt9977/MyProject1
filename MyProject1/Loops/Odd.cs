using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class Odd
    {
        //Odd betn 15 to 35 
        static void Main(string[] args)
        {
            for(int i=15;i<=35;i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class WhileLoop
    {
        static void Main(string[] args)
        {

            //initialization
            //while(condition)
            //  {
            //    logic
            //      increment/decrement
            //  }
            int i = 1;
            while (i <= 5) 
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}

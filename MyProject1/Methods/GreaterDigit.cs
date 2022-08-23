using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class GreaterDigit
    {

        //162
        //1958
        static void Main(string[] args)
        {
            int gr = 1;
            int n = 162;
            int next = n % 10;
            n = n / 10;

            while (n>0)
            {
                int prev = n % 10;
                n = n / 10;

                if(prev>next)
                {
                    gr = prev;
                }
              

            }
            Console.WriteLine(gr);

        }
    }
}

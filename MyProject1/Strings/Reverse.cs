using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Strings
{
    class Reverse
    {
        static void Main(string[] args)
        {
            string s = "Shivam Thorat";
            int a = s.Length;
            // Console.WriteLine(a);

            

            for(int i=a-1;i>=0;i--)
            {
                Console.Write(s[i]);
            }
        }
    }
}

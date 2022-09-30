using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Strings
{
    class Spliting
    {
        static void Main(string[] args)
        {
            string s = "Shivam Thorat";

            int c = 0;
            for(int i=0;i<s.Length-1;i++)
            {
                if(s[i]==' ')
                {
                    c++;
                }
            }
            int ans = c + 1;
            Console.WriteLine("Total NUmber Of words are : "+ans);
        }
    }
}

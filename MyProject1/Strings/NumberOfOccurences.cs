using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Strings
{
    class NumberOfOccurences
    {
        static void Main(string[] args)
        {
            string s = "dhdgvfdjud";
            int c = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]=='d')
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}

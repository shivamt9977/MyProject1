using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Strings
{
    class Pallindrome
    {
        static void Main(string[] args)
        {
            string s = "abcdcba";

            for(int i=s.Length-1;i>=0;i--)
            {
               Console.Write(s[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Strings
{
    class EmailId
    {
        static void Main(string[] args)
        {
            string s = "Shivamgmail.com";
            int a = 0;
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] == '@')
                {
                    a = 1;
                }
               
                if (a==1)
                {
                    if (s[i] == '.')
                    {
                        Console.WriteLine("Valid Email Id");
                    }
                }
               
            }
           
        }
    }
}

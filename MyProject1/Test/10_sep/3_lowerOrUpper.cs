using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._10_sep
{
    class _3_lowerOrUpper
    {
        public void Check(char ch)
        {
            if(ch>='A' && ch<='Z')
            {
                Console.WriteLine("Char is in Upper Case");
            }
            else
            Console.WriteLine("Char is in Lower Case");
        }
        static void Main(string[] args)
        {
            _3_lowerOrUpper l = new _3_lowerOrUpper();
            char ch = Convert.ToChar(Console.ReadLine());
            l.Check(ch);
        }
    }
}

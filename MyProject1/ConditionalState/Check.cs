using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class Check
    {
        static void Main(string[] args)
        {
            //check char or digit or simbol
            Console.WriteLine("Enter the Char");
            char ch = Convert.ToChar(Console.ReadLine());

            if((ch>='A' && ch<='Z') || (ch>='a'&&ch<='z'))
            {
                Console.WriteLine("Alphabet");
            }
            else if(ch>='0' && ch<='9')
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Symbol");
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class Switchdemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 'a': Console.WriteLine("Vowel");
                    break;
                case 'e': Console.WriteLine("Vowel");
                    break;
                case 'i':Console.WriteLine("Vowel");                  
                    break;
                case 'o':Console.WriteLine("Vowel");                   
                    break;
                case 'u':Console.WriteLine("Vowel");
                    break;

                default: Console.WriteLine("Consonent");
                    break;

            }
        }
    }
}

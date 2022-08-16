using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class Vovels

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Char");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch=='a'|| ch=='A')
            {
                Console.WriteLine("Vovel");
            }
            else if(ch=='e' || ch=='E')
            {
                Console.WriteLine("Vovel");
            }
            else if (ch == 'i' || ch == 'I')
            {
                Console.WriteLine("Vovel");
            }
            else if (ch == 'o' || ch == 'O')
            {
                Console.WriteLine("Vovel");
            }
            else if (ch == 'u' || ch == 'U')
            {
                Console.WriteLine("Vovel");
            }
            else
            {
                Console.WriteLine("Cosonent");

            }
        }
    }
}

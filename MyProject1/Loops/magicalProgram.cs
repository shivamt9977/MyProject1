using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class magicalProgram
    {
        static void Main(string[] args)
        {
            int magicnum = 45;

            while(true)
            {
                Console.WriteLine("Enter the number");
                int num = int.Parse(Console.ReadLine());
                if(num>magicnum)
                {
                    Console.WriteLine("Num is Greater\n");
                }
                else if(num<magicnum)
                {
                    Console.WriteLine("Num is Smaller\n");
                }
                else
                {
                    Console.WriteLine("Yesss.....Perfect Number\n");
                }
            }
        }
    }
}

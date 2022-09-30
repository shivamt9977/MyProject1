using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Strings
{
    class StartWith
    {
        static void Main(string[] args)
        {
            string myString = "My Name Is Shivam";

            Console.WriteLine(myString.StartsWith("My"));//true
            Console.WriteLine(myString.StartsWith("Shivam"));//False
            Console.WriteLine(myString.EndsWith("Shivam"));//True
        }
    }
}

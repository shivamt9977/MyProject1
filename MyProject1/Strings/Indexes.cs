using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Strings
{
    class Indexes
    {
        static void Main(string[] args)
        {
            string myString = "Shivam";

            Console.WriteLine(myString.IndexOf('S'));
            Console.WriteLine(myString.IndexOf('h'));
            Console.WriteLine(myString.IndexOf('i'));
            Console.WriteLine(myString.IndexOf('v'));
            Console.WriteLine(myString.IndexOf('a'));
            Console.WriteLine(myString.IndexOf('m'));
            Console.WriteLine();

            Console.WriteLine(myString.LastIndexOf('a'));

            Console.WriteLine("String Length is " + myString.Length);
        }
    }
}

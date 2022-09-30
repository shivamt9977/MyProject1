using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Strings
{
    class Containes
    {
        static void Main(string[] args)
        {
            string myString = "My Name Is Shivam";

            Console.WriteLine(myString.Contains(" "));
            Console.WriteLine(myString.Equals("My Name Is Shivam"));
            Console.WriteLine(myString.Equals("my name is shivam"));
            Console.WriteLine(myString.Equals("my name is shivam",StringComparison.OrdinalIgnoreCase));
        }
    }
}

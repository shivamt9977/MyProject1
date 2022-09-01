using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Inheritance
{
    class Vehicle
    {
        string vtype;
        int cubicCap;

       public void accept()
        {
            Console.WriteLine("In Accept");
        }
    }

    class bullet : Vehicle
    {
        
        string vname;

        static void Main(string[] args)
        {
            bullet v = new bullet();
            v.accept();
        }
        

    }

}

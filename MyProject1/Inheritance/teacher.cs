using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Inheritance
{
    class Teacher
    {
        string techername;
        string qualification;
        long mobnumb;

        public Teacher()
        {
            Console.WriteLine("Default constrct");        
        }




    }

    class permenent:Teacher
    {
        public permenent()
        {
            Console.WriteLine("In permanent teacher");
        }
    }
}

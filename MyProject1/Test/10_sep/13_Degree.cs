using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._10_sep
{
    class Degree
    {

        public void getDegree()
        {
            Console.WriteLine("I got degree");
        }
    }
    class Undergraduate : Degree
    { 
        public void getDegree()
        {
            Console.WriteLine("I am Undergraduate");
        }
    }
    class Postgraduate:Degree
    {
        public void getDegree()
        {
            Console.WriteLine("I am Postgraduate");
        }
    }

    class main1
    {
        static void Main(string[] args)
        {
            Degree d = new Degree();
            d.getDegree();

            Undergraduate d1 = new Undergraduate();
            d1.getDegree();

            Postgraduate d3 = new Postgraduate();
            d3.getDegree();
        }
    }
}

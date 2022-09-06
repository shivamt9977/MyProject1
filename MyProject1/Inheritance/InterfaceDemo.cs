using MyProject1.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Inheritance
{


    interface ICalculator
    {
        void add(int a, int b);
        void subtract(int a, int b);

    }

    interface ScientificCalculator : ICalculator
    {
        void mul(int a, int b);
        void div(int a, int b);
    }

    class calculate:ScientificCalculator,ICalculator
    {
        public void add(int a,int b)
        {
            Console.WriteLine("Sum is "+(a+b));
        }

        public void div(int a, int b)
        {
            Console.WriteLine("Div is "+(a/b));        }

        public void mul(int a, int b)
        {
            Console.WriteLine("Mul is " + (a * b));
        }

        public void subtract(int a, int b)
        {
            Console.WriteLine("Sub is " + (a - b));
        }
    }

  

}

    


    class InterfaceDemo
    {

        static void Main(string[] args)
        {
         ScientificCalculator c = new calculate();
            c.add(5, 6);
        }
    }


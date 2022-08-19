using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class NamePattern
    {
        public void S()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || i == 5 || i == 3 || (j == 1 && i <= 3) || (j==5 && i>=3))
                    {
                        
                            Console.Write("*");
                        

                    }
                    else
                    {
                        Console.Write(" ");

                    }
                   


                }
                Console.WriteLine();
            }
        }

        public void H()
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if ( j == 1 || j == 5 || i==3)
                    {

                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void I()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || j == 3 || i == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void V()
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if ((i==1 && j==1) || (i == 2 && j == 1) || (i == 4 && j == 2)|| (i==5 && j==3) || (i == 4 && j == 4) || (i == 2 && j == 5) || (i == 1 && j == 5))
                    {

                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            NamePattern s1 = new NamePattern();
            s1.S();
            Console.WriteLine();

            NamePattern h1 = new NamePattern();    
            h1.H();
            Console.WriteLine();

            NamePattern i1 = new NamePattern();
            i1.I();

            Console.WriteLine();
            NamePattern v1 = new NamePattern();
            v1.V();
        }
    }
}

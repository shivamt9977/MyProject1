using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class Nested
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the passing Year");
            int yr = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marks");
            int mr = int.Parse(Console.ReadLine());

            if(yr==2021)
            {
                if(mr>60)
                {
                    Console.WriteLine("Valid Candidate");
                }
                else
                {
                    Console.WriteLine("Low Percentage");

                }
            }
            else
            {
                Console.WriteLine("InValid Candidate");

            }


        }
    }
}

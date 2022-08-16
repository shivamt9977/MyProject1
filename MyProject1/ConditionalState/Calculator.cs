using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ConditionalState
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            Console.WriteLine("\n");

            Console.WriteLine("Enter The 1st Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The 2nd Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Enter the Choice");
            int choice = int.Parse(Console.ReadLine());

            int ans;

            switch(choice)
            {
                case 1: ans=num1 + num2;
                    Console.WriteLine("Addition is "+ans);
                    break;
                case 2: ans = num1 - num2;
                    Console.WriteLine("Subtraction is "+ans);
                    break;
                case 3:
                    ans = num1 * num2;
                    Console.WriteLine("Multiplication is " + ans);
                    break;
                case 4:
                    ans = num1 / num2;
                    Console.WriteLine("Division is " + ans);
                    break;

            }
            
        }
    }
}

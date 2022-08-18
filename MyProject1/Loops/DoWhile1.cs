using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Loops
{
    class DoWhile1
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
            Console.WriteLine("Enter the 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("1.addition\n2.Subtraction\n3.Multiplication\n4.Division");
            Console.WriteLine("Enter the choice");
            int choice = int.Parse(Console.ReadLine());
        


           

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition is " + (num1 + num2));
                        break;

                    case 2:
                        Console.WriteLine("Subtraction is " + (num1 - num2));
                        break;

                    case 3:
                        Console.WriteLine("Multiplication is " + (num1 * num2));
                        break;

                    case 4:
                        Console.WriteLine("Division is " + (num1 / num2));
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
                Console.WriteLine("Do you want to continue.....");

                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y' || ch == 'Y');

        }
    }
}

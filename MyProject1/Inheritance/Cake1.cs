using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Inheritance
{

    interface Cake
    {
        void bake();
        

        
    }

    class Strawberry:Cake
    {
        public void bake()
        {
            Console.WriteLine("Baking Strawberry Cake");
        }
    }
    class BlackForest:Cake
    {
        public void bake()
        {
            Console.WriteLine("Baking BlackForest Cake");
        }
    }

    class CakeTest
    {
        static void Main(string[] args)
        {
            Cake c = new Strawberry();
            c.bake();
            Cake c1 = new BlackForest();
            c1.bake();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class Car
    {
        string carName;
        int price;
        string engType;

        public Car()
        {

        }

        public Car(string car,int p,string type)
        {
            carName = car;
            price = p;
            engType = type;
        }

       /* public override string ToString()
        {
            return "Carname " + carName +"Price is"+price+"Engtype is "+engType;
        }*/

        static void Main(string[] args)
        {
            Car c1 = new Car();//default constructor
            Car c2 = new Car("Honda City",2000000,"ivtech");//3 parameter
            Console.WriteLine(c2.carName+","+c2.price+","+c2.engType);

           // string s = new string();
        }
    }
}

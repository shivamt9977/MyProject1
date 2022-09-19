using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class Employee
    {
        string ename;
        int eid;
        string eskills;

        public void showdata()
        {
            Console.WriteLine("Nmae: "+Ename+" Id: "+Eid+" Skills:"+Eskills);
        }

        public Employee(string ename,int eid,string eskills)
        {
            this.ename = ename;
            this.eid = eid;
            this.eskills = eskills;
        }
        public string Ename
        {
            set { ename = value; }
            get { return ename; }
        }
        public int Eid
        {
            set { eid = value; }
            get { return eid; }
        }
        public string Eskills
        {
            set { eskills = value; }
            get { return eskills; }
        }



        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];
            for(int i=0;i<emp.Length;i++)
            {
                Console.WriteLine("Enter name,id,skills");
                string nm =(Console.ReadLine());
                int id = int.Parse(Console.ReadLine());
                string sk =(Console.ReadLine());

                emp[i] = new Employee(nm, id, sk);
            }

            for(int i=0;i<emp.Length;i++)
            {
                emp[i].showdata();
            }

           

            
            

        }
    }
}
